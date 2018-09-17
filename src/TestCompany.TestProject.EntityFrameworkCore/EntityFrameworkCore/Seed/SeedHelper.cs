﻿using System;
using System.Transactions;
using Microsoft.EntityFrameworkCore;
using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.EntityFrameworkCore.Uow;
using Abp.MultiTenancy;
using TestCompany.TestProject.EntityFrameworkCore.Seed.Host;
using TestCompany.TestProject.EntityFrameworkCore.Seed.Tenants;
using System.IO;

namespace TestCompany.TestProject.EntityFrameworkCore.Seed
{
    public static class SeedHelper
    {
        public static void SeedHostDb(IIocResolver iocResolver)
        {
            WithDbContext<TestProjectDbContext>(iocResolver, SeedHostDb);
        }

        public static void SeedHostDb(TestProjectDbContext context)
        {
            context.SuppressAutoSetTenantId = true;

            // Host seed
            new InitialHostDbBuilder(context).Create();

            // Default tenant seed (in host database).
            new DefaultTenantBuilder(context).Create();
            new TenantRoleAndUserBuilder(context, 1).Create();

            //Seed Invoices
            string sql = Path.Combine(AppContext.BaseDirectory, "EntityFrameworkCore\\Seed\\Scripts\\SeedInvoices.sql");
            context.Database.ExecuteSqlCommand(File.ReadAllText(sql));
        }

        private static void WithDbContext<TDbContext>(IIocResolver iocResolver, Action<TDbContext> contextAction)
            where TDbContext : DbContext
        {
            using (var uowManager = iocResolver.ResolveAsDisposable<IUnitOfWorkManager>())
            {
                using (var uow = uowManager.Object.Begin(TransactionScopeOption.Suppress))
                {
                    var context = uowManager.Object.Current.GetDbContext<TDbContext>(MultiTenancySides.Host);

                    contextAction(context);

                    uow.Complete();
                }
            }
        }
    }
}
