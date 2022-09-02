using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Services
{
    class TempMailService
    {
        private OneSecmail _oneSecmail;

        public TempMailService(OneSecmail oneSecmail)
        {
            _oneSecmail = oneSecmail;
        }

        public string GetMailbox()
        {
            return _oneSecmail.GetMailbox();
        }
    }
}