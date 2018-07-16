using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFBrokerage.Models.BrokerageSlab
{
    public class BrokerageSlabHeaderModel
    {
        public int AMC { get; set; }
        public int Category { get; set; }
        public string Scheme { get; set; }
        public DateTime BrokeragePeriodFrom { get; set; }
        public DateTime BrokeragePeriodTo { get; set; }
        public int ClawbackPeriod { get; set; }
    }
}