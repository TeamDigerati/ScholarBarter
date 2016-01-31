using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScholarBarter.Models.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException() : 
            base("The 'From' and/or 'To' address is not properly formated") {}
    }
}