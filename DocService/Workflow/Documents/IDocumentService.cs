using System;
using System.Collections.Generic;


namespace DocService.Workflow.Documents
{
    public interface IDocumentService
    {
        List<NewDocumentManagement> GetDocuments(string invoiceNumber);
    }
}
