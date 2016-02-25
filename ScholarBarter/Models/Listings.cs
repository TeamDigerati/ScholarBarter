using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScholarBarter.Models
{
    public class Listings 
    {

      public int Id { get; set; }
      [StringLength(50)]
      public string Product { get; set; }
      public decimal Price { get; set; }
      public int Quantity { get; set; }
      public DateTime Date { get; set; }
      public int CustomerId { get; set; }
      public User User { get; set; }

      public Listings Clone()
      {
        return (Listings)this.MemberwiseClone();
      }

    }
}
