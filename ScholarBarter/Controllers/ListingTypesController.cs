using System.Linq;
using System.Web.Helpers;
using System.Web.Http;
using ScholarBarter.Models.DataContexts;

namespace ScholarBarter.Controllers
{
    public class ListingTypesController : ApiController
    {
        [HttpGet]
        public string GetListingTypes()
        {
            ListingTypeDataContext dc = new ListingTypeDataContext();

            var result =
                from a in dc.GetTable<ListingType>()
                select a;

            return Json.Encode(result);
        }
    }
}
