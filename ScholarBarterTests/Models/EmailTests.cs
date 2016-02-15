using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScholarBarter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ScholarBarter.Models.Tests
{
    [TestClass()]
    public class EmailTests
    {
        /* 
         * Note: 
         * cannot test the actual sending of an email for two reasons
         * 1) it would require fetching the mail from a mail box which 
         *    would require defining a user name and password here
         *    which would make it publicly viewable on github
         * 2) Simply.Mail requires a key to be added to Web.config.
         *    it cannot access that key from within the test project nor
         *    does defining the key here help. 
        */
        Email e = new Email
        {
            From = "support@scholarbarter.com",
            To = "dom@domsnet.net",
            Subject = "This is a test",
            Body = "<h2>Testing</h2>"
        };

        [TestMethod]
        public void validEmailTest()
        {
            Assert.IsTrue(e.isValid);
        }

        [TestMethod]
        public void invalidFromAddress()
        {
            string oldFrom = e.From;

            e.From = "support@scholarbarter,com";

            Assert.IsFalse(e.isValid);

            e.From = oldFrom;
        }

        [TestMethod]
        public void invalidToAddress()
        {
            string oldTo = e.To;

            e.To = "devnull@domsnet,net";

            Assert.IsFalse(e.isValid);

            e.To = oldTo;
        }
    }
}
