using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFBrokerage.Models.BrokerageSlab
{
    public class BrokerageSlabFlatFeesModel
    {
        public int BrokerageType { get; set; }
        public double Rate { get; set; }
        public double AmountFrom { get; set; }
        public double AmountTo { get; set; }
        public int Location { get; set; }
        public bool IncludeSIPSTP { get; set; }        
    }
}