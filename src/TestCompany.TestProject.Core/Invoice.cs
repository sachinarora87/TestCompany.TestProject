using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCompany.TestProject.Authorization.Users;

namespace TestCompany.TestProject
{
    public class Invoice : AuditedEntity<long, User>, IMustHaveTenant
    {
        public DateTime OrderDate { get; set; }
        public int OrderNumber { get; set; }
        public int InvoiceNumber { get; set; }
        public virtual ICollection<InvoiceLine> InvoiceLines { get; set; }
        public virtual long PalletId { get; set; }
        public virtual int TenantId { get; set; }
    }

}
