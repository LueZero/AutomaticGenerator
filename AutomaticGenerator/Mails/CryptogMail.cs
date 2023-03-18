using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutomaticGenerator.Helpers;
using AutomaticGenerator.Models.Responses.CryptogMails;
using Newtonsoft.Json;

namespace AutomaticGenerator.Mails
{
    public class CryptogMail : Mail
    {
        public CryptogMail()
        {            
            BaseUrl = "https://cryptogmail.com";
        }

        public override string GetMailbox()
        {
            return Information.RandomString(20, true) + GetDomains().First();
        }

        public List<string> GetDomains()
        {
            HttpResponseMessage response = Client.GetAsync(BaseUrl + "/api/domains.config.json").Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;

            var domains = JsonConvert.DeserializeObject<Domain>(responseBody);

            return domains.Domains;
        }

        public override Content GetMessages(string inbox = "agawagwagawg@vintomaper.com")
        {
            HttpResponseMessage response = Client.GetAsync(BaseUrl + "/api/emails/?action=getMessages&inbox=" + inbox).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Content>(responseBody);
        }

        public string GetEmailContent(string id = "ee67caa8-0b87-4e29-9a88-616215670d20")
        {
            HttpResponseMessage response = Client.GetAsync(BaseUrl + "/api/emails/" + id).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;

            return responseBody;
        }
    }
}
