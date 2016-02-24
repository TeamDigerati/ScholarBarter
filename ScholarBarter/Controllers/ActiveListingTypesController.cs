﻿using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models;
using ScholarBarter.Models.DataContexts;
using ScholarBarter.Models.Exceptions;

namespace ScholarBarter.Controllers
{
    public class ActiveListingTypesController : ApiController
    {
        [HttpGet]
        public string GetAllListingTypes(string sessionKey)
        {
            if (!SessionValidator.Validate(sessionKey))
                return Json.Encode(new InvalidSessionException());

            ListingTypeDataContext dc = new ListingTypeDataContext();

            var result =
                from a in dc.GetTable<ListingType>()
                where a.Active
                select a;

            return Json.Encode(result);
        }
    }
}
