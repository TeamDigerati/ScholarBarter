using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
namespace ScholarBarter.Library
{
    public class ValidatePhone
    {
        public  bool IsPhoneNumber(string number)
        {
            string MatchPhoneNumberPattern = "^\\(?([0-9]{3})\\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
   if (number!= null) return Regex.IsMatch(number, MatchPhoneNumberPattern );
   else return false;
        }
    }
}