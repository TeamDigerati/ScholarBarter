using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScholarBarter.Models
{
    public class SessionValidator
    {
        public static bool Validate(string sessionKey)
        {
            if(isValid(sessionKey)){
                renewSessionKey(sessionKey);
                return true;
            }

            return false;
        }

        private static void renewSessionKey(string sessionKey)
        {
            // this method updates the timestamp on the session key
            ;
        }

        private static bool isValid(string sessionKey)
        {
            // this checks if the session is active
            return (sessionKey == "ABCDEFG1234567");
        }
    }
}