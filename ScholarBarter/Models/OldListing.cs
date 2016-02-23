using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScholarBarter.Models
{
  public class OldListing
  {
      public int ListingId { get; set; }
      public int UserId { get; set; }
      public bool Active { get; set; }
      public string Type { get; set; }
      public string Description { get; set; }
      public DateTime CreationTime { get; set; }       
  }
}