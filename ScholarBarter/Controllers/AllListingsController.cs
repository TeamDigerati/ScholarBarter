using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models;
using ScholarBarter.Models.DataContexts;
using ScholarBarter.Models.Exceptions;

namespace ScholarBarter.Controllers
{
    public class AllListingsController : ApiController
    {
        [HttpGet]
        public string GetAllListings(string sessionKey)
        {
            if (!SessionValidator.Validate(sessionKey))
                return Json.Encode(new InvalidSessionException());

            ListingsDataContext dc = new ListingsDataContext();

            var result =
                from a in dc.GetTable<Listing>()
                select a;

            return Json.Encode(result);
        }
    }
}
