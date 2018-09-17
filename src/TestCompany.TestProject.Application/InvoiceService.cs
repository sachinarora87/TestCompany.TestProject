using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityHistory;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace TestCompany.TestProject
{
    public interface IInvoiceService
    {
        Task<UpdateOutputDto> UpdateAsync(UpdateInputDto updateInputDto);
    }
    public class InvoiceService : ApplicationService, IInvoiceService
    {
        private readonly IRepository<InvoiceLine, long> invoiceLineRepository;

        public InvoiceService(IRepository<InvoiceLine, long> invoiceLineRepository)
        {
            this.invoiceLineRepository = invoiceLineRepository;
        }

        [UseCase(Description = "Article Updated")]
        public async Task<UpdateOutputDto> UpdateAsync(UpdateInputDto updateInputDto)
        {
            var invoiceLine = invoiceLineRepository.GetAll()
             .Include(i => i.Invoice)
             .FirstOrDefault(x => x.CartonNumber == updateInputDto.CartonNumber);

            if (invoiceLine == null)
            {
                throw new EntityNotFoundException("Article not found");
            }

            invoiceLine.Status = InvoiceLineStatus.Updated;
            await invoiceLineRepository.UpdateAsync(invoiceLine).ConfigureAwait(false);

            return invoiceLine.MapTo<UpdateOutputDto>();
        }
    }
}
