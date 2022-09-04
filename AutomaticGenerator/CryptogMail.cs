using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator
{
    class CryptogMail
    {
        protected string baseUrl = "https://cryptogmail.com";

        public readonly HttpClient client;

        public CryptogMail()
        {
            client = new HttpClient();
        }

        public void GetEmails(string inbox = "agawagwagawg@vintomaper.com")
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/emails/?action=getMessages&inbox=" + inbox).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;
        }

        public void GetEmailContent(string id = "ee67caa8-0b87-4e29-9a88-616215670d20")
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/emails/" + id).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;
        }
    }
}
