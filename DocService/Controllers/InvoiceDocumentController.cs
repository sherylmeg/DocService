using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DocService.Workflow.Documents;
using Microsoft.Extensions.Logging;

namespace DocService.Controllers
{
    [Route("api/[controller]")]
    public class InvoiceDocumentController : Controller
    {
        private readonly ILogger<InvoiceDocumentController> _logger;
        private readonly IDocumentService _documentService;

        public InvoiceDocumentController(IDocumentService documentService, ILogger<InvoiceDocumentController> logger)


        {
            _logger = logger;
            _documentService = documentService;
        }  

        [HttpGet("getInvoiceDocuments/{invoiceNumber}")]
        public List<NewDocumentManagement> GetInvoiceDocuments([FromRoute] string invoiceNumber)
        {
            _logger.LogInformation("Getting docs for invoice {0}", invoiceNumber);

            var docs = _documentService.GetDocuments(invoiceNumber);
            return docs;
        }

    }
}
