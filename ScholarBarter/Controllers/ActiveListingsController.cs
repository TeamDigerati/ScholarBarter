using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models.DataContexts;
using ScholarBarter.Models;
using ScholarBarter.Models.Exceptions;

namespace ScholarBarter.Controllers
{
    public class ActiveListingsController : ApiController
    {
        [HttpGet]
        public string GetActiveListings(string sessionKey)
        {
            if(!SessionValidator.Validate(sessionKey))
                return Json.Encode(new InvalidSessionException());
	        
            ListingsDataContext dc = new ListingsDataContext();

            var result =
                from a in dc.GetTable<Listing>()
                where a.Active
                select a;

            return Json.Encode(result);
        }
    }
}
