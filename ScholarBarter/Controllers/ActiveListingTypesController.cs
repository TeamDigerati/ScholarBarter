using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models.DataContexts;

namespace ScholarBarter.Controllers
{
    public class ActiveListingTypesController : ApiController
    {
        [HttpGet]
        public string GetAllListingTypes()
        {
            ListingTypeDataContext dc = new ListingTypeDataContext();

            var result =
                from a in dc.GetTable<ListingType>()
                where a.Active
                select a;

            return Json.Encode(result);
        }
    }
}
