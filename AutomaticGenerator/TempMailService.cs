using AutomaticGenerator.Mails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator
{
    public class TempMailService
    {
        private Mail _mail;

        public TempMailService(Mail mail)
        {
            _mail = mail;
        }

        public string GetMailbox()
        {
            return _mail.GetMailbox();
        }

        public List<Models.Responses.OneSecMail.Message> GetMessages(string login = "demo", string domain = "1secmail.com")
        {
            var result = _mail.GetMessages(login, domain);

            return result;
        }

        public Models.Responses.CryptogMail.Content GetMessages(string inbox = "agawagwagawg@vintomaper.com")
        {
            var result = _mail.GetMessages(inbox: inbox);

            var data = result.Data;

            return result;
        }
    }
}