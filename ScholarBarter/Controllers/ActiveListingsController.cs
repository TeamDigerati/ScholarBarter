﻿using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models.DataContexts;

namespace ScholarBarter.Controllers
{
    public class ActiveListingsController : ApiController
    {
        [HttpGet]
        public string GetActiveListings()
        {
            ListingsDataContext dc = new ListingsDataContext();

            var result =
                from a in dc.GetTable<Listing>()
                where a.Active
                select a;

            return Json.Encode(result);
        }
    }
}
