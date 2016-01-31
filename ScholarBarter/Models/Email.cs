using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Simplify.Mail;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace ScholarBarter.Models
{
    public class Email
    {
        public string From { set; get; }
        public string To { set; get; }
        public string Subject { set; get; }
        public string Body { set; get; }

        public void send()
        {
            if (isValid)
            {
                MailSender sndr = new MailSender();
                sndr.Send(From, To, Subject, Body);
            }
            else
            {
                throw new Exception("The email is not properly formated");
            }
        }

        private bool isValid
        {
            get
            {
                var validator = new EmailAddressAttribute();

                return (validator.IsValid(From) && validator.IsValid(To));
            }
        }
    }
}