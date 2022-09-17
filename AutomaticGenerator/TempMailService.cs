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
        private OneSecMail _oneSecMail;

        private CryptogMail _cryptogMail;

        public TempMailService()
        {
            _oneSecMail = new OneSecMail();
            _cryptogMail = new CryptogMail();
        }

        public string GetOneSecMailbox()
        {
            return _oneSecMail.GetMailbox();
        }

        public string GetCryptogSecMailbox()
        {
            return _cryptogMail.GetMailbox();
        }
    }
}