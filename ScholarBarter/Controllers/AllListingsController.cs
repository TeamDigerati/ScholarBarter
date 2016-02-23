using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
//using System.Web.Mvc;
using ScholarBarter.Models.DataContexts;

namespace ScholarBarter.Controllers
{
    public class AllListingsController : ApiController
    {
        [HttpGet]
        public string GetAllListings()
        {
            ListingsDataContext dc = new ListingsDataContext();

            var result =
                from a in dc.GetTable<Listing>()
                select a;

            return Json.Encode(result);
        }
    }
}
