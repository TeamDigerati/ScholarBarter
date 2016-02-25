using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ScholarBarter.Models
{
  public class User
  {
    public int Id { get; set; }
    [StringLength(50)]
    public string FirstName { get; set; }
    [StringLength(50)]
    public string LastName { get; set; }
    [StringLength(100)]
    public string Email { get; set; }
    [StringLength(1000)]
    [JsonConverter(typeof(StringEnumConverter))]
    public Gender Gender { get; set; }
    public ICollection<Listings> Listings { get; set; }

  }
  public enum Gender
  {
    Female,
    Male
  }
}