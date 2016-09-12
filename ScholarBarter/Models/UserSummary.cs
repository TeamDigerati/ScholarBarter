﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ScholarBarter.Models
{
  public class UserSummary
  {
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ListingCount { get; set; }
    [JsonConverter(typeof(StringEnumConverter))]
    public Gender Gender { get; set; }
  }
}