using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFBrokerage.Models
{
    public class ChequeEntryModel
    {
        public DateTime ChequeDate { get; set; }
        public DateTime ChequeReceivedDate { get; set; }
        public Int64 ChequeNumber { get; set; }
        public double ChequeAmount { get; set; }
        public double Tax { get; set; }
        public DateTime BrokeragePeriodFrom { get; set; }
        public DateTime BrokeragePeriodTo { get; set; }
        public int Bank { get; set; }
        public int Branch { get; set; }
        public string ReferenceTag { get; set; }
        public double Trail { get; set; }
        public double Upfront { get; set; }
        public double Clawback { get; set; }
        public double Total { get; set; }
        public string Remarks { get; set; }
    }
}