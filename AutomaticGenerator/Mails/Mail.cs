using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Mails
{
    public abstract class Mail
    {
        public abstract string GetMailbox();

        public virtual List<Models.Responses.OneSecMail.Message> GetMessages(string login, string domain)
        {
            return new List<Models.Responses.OneSecMail.Message>();
        }

        public virtual Models.Responses.CryptogMail.Content GetMessages(string inbox)
        {
            return new Models.Responses.CryptogMail.Content();
        }
    }
}
