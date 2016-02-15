using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScholarBarter.Library;

namespace ScholarBarterTests.Models.Test
{
   [TestClass]

    public class ValidateEmailAddress
    {
        [TestMethod]
        public void validEmailTest()
        {
            EmailValidation util = new EmailValidation();
            string emailAddresses =  "asingh@cpp.edu" ;
            Assert.IsTrue(util.IsValidEmail(emailAddresses));

        }
        [TestMethod]
        public void invalidEmailTest()
        {
            EmailValidation util = new EmailValidation();
            string emailAddresses = "asingh@yahoo.edu";
            Assert.IsFalse(util.IsValidEmail(emailAddresses));

        }
        [TestMethod]
        public void invalidfomratEmailTest()
        {
            EmailValidation util = new EmailValidation();
            string emailAddresses = "asinghcpp.edu";
            Assert.IsFalse(util.IsValidEmail(emailAddresses));

        }
    }
}
