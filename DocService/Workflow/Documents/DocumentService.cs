using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace DocService.Workflow.Documents
{
    public class DocumentService : IDocumentService
    {
        private readonly ILogger<DocumentService> _logger;
        private readonly IDocumentRepository _documentRepository;

        public DocumentService(IDocumentRepository documentRepository, ILogger<DocumentService> logger)
        {
            _logger = logger;
            _documentRepository = documentRepository;
        }

        public List<NewDocumentManagement> GetDocuments(string invoiceNumber)
        {
            return _documentRepository.GetDocumentsForInvoice(invoiceNumber);

        }       

    }
}
