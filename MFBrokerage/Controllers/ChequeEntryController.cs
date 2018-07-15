using MFBrokerage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using MFBrokerage.BusinessModel;

namespace MFBrokerage.Controllers
{
    public class ChequeEntryController : Controller
    {
        //private IMapper _mapper;
        // GET: ChequeEntry
        public ActionResult Cheque()
        {
            return View();
        }

        [Route("ChequeEntry/CreateCheque")]
        public ActionResult CreateCheque(ChequeEntryModel chequeEntryModel)
        {   
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<ChequeEntryModel, ChequeEntry>(); });
            //_mapper = config.CreateMapper();            
            ChequeEntry chequeEntry = config.CreateMapper().Map<ChequeEntryModel, ChequeEntry>(chequeEntryModel);
            return View();
        }
    }
}