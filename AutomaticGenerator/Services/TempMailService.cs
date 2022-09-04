using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Services
{
    class TempMailService
    {
        private OneSecMail _oneSecMail;

        public TempMailService(OneSecMail oneSecMail)
        {
            _oneSecMail = oneSecMail;
        }

        public string GetMailbox()
        {
            return _oneSecMail.GetMailbox();
        }
    }
}