using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScholarBarter.Library;


namespace ScholarBarterTests.Models.Test
{
    [TestClass]
    public class ValidatePhoneTest
    {
        [TestMethod]
        public void ValidPhoneTest()
        {
         ValidatePhone util = new ValidatePhone();
         string phonenumber = "3114567777";
         Assert.IsTrue(util.IsPhoneNumber(phonenumber));
         }
        [TestMethod]
        public void inValidPhoneTest()
        {
        ValidatePhone util = new ValidatePhone();
         string phonenumber = "3A114567777";
         Assert.IsFalse(util.IsPhoneNumber(phonenumber));
         }

    }
}
