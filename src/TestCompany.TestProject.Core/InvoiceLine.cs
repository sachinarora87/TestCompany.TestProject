using Abp.Auditing;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using TestCompany.TestProject.Authorization.Users;

namespace TestCompany.TestProject
{
    [Audited]
    public class InvoiceLine : AuditedEntity<long, User>, IMustHaveTenant
    {
        public string ArticleNumber { get; set; }
        public string ArticleDescription { get; set; }
        public int Quantity { get; set; }
        public int PackSize { get; set; }
        public int CartonNumber { get; set; }
        public decimal CartonWeight { get; set; }
        public decimal ChargeWeight { get; set; }
        public InvoiceLineStatus Status { get; set; }
        public virtual long InvoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual int TenantId { get; set; }
    }

    public enum InvoiceLineStatus
    {
        Created,
        Updated,
        Cancelled,
    }
}
