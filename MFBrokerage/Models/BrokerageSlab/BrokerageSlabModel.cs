using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFBrokerage.Models.BrokerageSlab
{
    public class BrokerageSlabModel
    {
        public BrokerageSlabHeaderModel BrokerageSlabHeaderModel { get; set; }        
        public List<BrokerageSlabTrailFeesModel> ListBrokerageSlabTrailFeesModel { get; set; }
        public List<BrokerageSlabFlatFeesModel> ListBrokerageSlabFlatFeesModel { get; set; }
    }
}