using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocService.Workflow.Documents
{
    public interface IDocumentRepository
    {
        List<NewDocumentManagement> GetDocumentsForInvoice(string invoiceNumber);
    }
}
