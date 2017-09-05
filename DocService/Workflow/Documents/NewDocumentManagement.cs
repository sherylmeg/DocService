﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocService.Workflow.Documents
{
    public class NewDocumentManagement
    {       
        public System.Guid DocGUID { get; set; }
        public string FileNumber { get; set; }
        public string DocPath { get; set; }
        public Nullable<System.Guid> TypeID { get; set; }
        public string AccountCode { get; set; }
        public string DescriptionField { get; set; }
        public Nullable<bool> Approval { get; set; }
        public Nullable<bool> CarrierInfo { get; set; }
        public Nullable<bool> Load_UnloadReceipt { get; set; }
        public Nullable<bool> DeliveryReceipt { get; set; }
        public Nullable<bool> ACH_QuickPayForm { get; set; }
        public Nullable<bool> ARInvoice { get; set; }
        public Nullable<bool> ProofOfDelivery { get; set; }
        public Nullable<bool> Comcheck { get; set; }
        public Nullable<bool> InsuranceDocument { get; set; }
        public Nullable<bool> CarrierInvoice { get; set; }
        public Nullable<bool> factoringInfo { get; set; }
        public Nullable<bool> WeightOrScaleTicket { get; set; }
        public Nullable<bool> EmailMessage { get; set; }
        public Nullable<bool> CashReceipt { get; set; }
        public Nullable<bool> Credit { get; set; }
        public Nullable<bool> LoadDetail { get; set; }
        public Nullable<bool> Contract { get; set; }
        public Nullable<bool> FaxConfirmation { get; set; }
        public Nullable<bool> PrintWithInvoices { get; set; }
        public Nullable<bool> PrintWithChecks { get; set; }
        public Nullable<bool> DisplayInList { get; set; }
        public System.DateTime DateAttached { get; set; }
        public string EnteredBy { get; set; }
        }
    }

