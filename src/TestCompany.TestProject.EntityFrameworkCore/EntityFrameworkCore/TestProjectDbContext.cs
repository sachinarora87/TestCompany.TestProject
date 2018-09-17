using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TestCompany.TestProject.Authorization.Roles;
using TestCompany.TestProject.Authorization.Users;
using TestCompany.TestProject.MultiTenancy;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TestCompany.TestProject.EntityFrameworkCore
{
    public class TestProjectDbContext : AbpZeroDbContext<Tenant, Role, User, TestProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public virtual DbSet<Invoice> Invoices { get; set; }

        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; }

        public TestProjectDbContext(DbContextOptions<TestProjectDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>(null, "Abp");


            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasMany(e => e.InvoiceLines).WithOne(i => i.Invoice).HasForeignKey(x => x.InvoiceId);
            });

            modelBuilder.Entity<InvoiceLine>(entity =>
            {
                entity.Property(e => e.Status).HasMaxLength(50).HasConversion(new EnumToStringConverter<InvoiceLineStatus>());
                entity.HasIndex(e => e.CartonNumber).IsUnique();
            });
        }
    }
}
