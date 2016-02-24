using System;

namespace ScholarBarter.Models.Exceptions
{
    public class InvalidSessionException : Exception
    {
        public InvalidSessionException() :
            base("This is not a valid session") { }
    }
}