using MFBrokerage.Models.BrokerageSlab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MFBrokerage.Controllers
{
    public class BrokerageSlabController : Controller
    {
        // GET: BrokerageSlab
        public ActionResult Create()
        {
            return View();
        }
        [Route("BrokerageSlab/CreateFlatFees")]
        [HttpPost]
        public ActionResult CreateFlatFees(List<BrokerageSlabFlatFeesModel> listBrokerageSlabFlatFeesModel)
        {
            return View();
        }
    }
}