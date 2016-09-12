using System;

namespace ScholarBarter.Models.Exceptions
{
    public class InvalidEmailException : Exception
    {
        public InvalidEmailException() : 
            base("The 'From' and/or 'To' address is not properly formated") {}
    }
}