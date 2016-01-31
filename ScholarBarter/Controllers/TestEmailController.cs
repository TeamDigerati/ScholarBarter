using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ScholarBarter.Models;

namespace ScholarBarter.Controllers
{
    public class TestEmailController : ApiController
    {
        [HttpPost]
        public string testEmail()
        {
            Email e = new Email
            {
                From = "support@scholarbarter.com",
                To = "dom@domsnet.net",
                Subject = "This is a test",
                Body = "<h2>Testing</h2>"
            };

            try
            {
                e.send();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            return "Success";
        }
    }
}
