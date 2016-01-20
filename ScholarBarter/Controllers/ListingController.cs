using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using ScholarBarter.Models;

namespace ScholarBarter.Controllers
{
   
    public class ListingController : ApiController
    {
      private Listing[] listings = new Listing[]
      {
        new Listing {ID = 1, ListName = "CS580 tutoring", description = "test1234 ....", Date = "1/1/16"},
        new Listing {ID = 2, ListName = "CS334 tutoring", description = "test1234 ....", Date = "1/1/16"},
        new Listing {ID = 3, ListName = "Math Tutoring", description = "test1234 ....", Date = "1/1/16"}
      };

      public IEnumerable<Listing> GetAllListing()
      {
        return listings;
      }

    }
}
