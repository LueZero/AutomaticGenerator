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
        protected string baseUrl = "https://cryptogmail.com";

        public readonly HttpClient client;

        public CryptogMail()
        {
            client = new HttpClient();
        }

        public override string GetMailbox()
        {
            return Information.RandomString(20, true) + GetDomains().First();
        }

        public List<string> GetDomains()
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/domains.config.json").Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;

            var domains = JsonConvert.DeserializeObject<Domain>(responseBody);

            return domains.Domains;
        }

        public override Content GetMessages(string inbox = "agawagwagawg@vintomaper.com")
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/emails/?action=getMessages&inbox=" + inbox).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;

            return JsonConvert.DeserializeObject<Content>(responseBody);
        }

        public string GetEmailContent(string id = "ee67caa8-0b87-4e29-9a88-616215670d20")
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/emails/" + id).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;

            return responseBody;
        }
    }
}
