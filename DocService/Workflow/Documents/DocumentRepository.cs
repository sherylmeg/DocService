using DocService.Workflow.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace DocService.Workflow.Documents
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly LMSNetDocumentsContext _lmsNetDocumentsContext;
        private readonly ILogger<DocumentRepository> _logger;

        public DocumentRepository(LMSNetDocumentsContext context, ILogger<DocumentRepository> logger)
        {
            _logger = logger;
            _lmsNetDocumentsContext = context;
        }

        public List<NewDocumentManagement> GetDocumentsForInvoice(string invoiceNumber)
        {
            List<NewDocumentManagement> documents = _lmsNetDocumentsContext.NewDocumentManagement
                .Where(s => s.FileNumber == invoiceNumber)
                .Where(s => s.PrintWithInvoices == true).ToList();

            return documents;
        }
    }
}
