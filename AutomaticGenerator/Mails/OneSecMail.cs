using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AutomaticGenerator.Models.Responses.OneSecMail;
using Newtonsoft.Json;

namespace AutomaticGenerator.Mails
{
    public class OneSecMail : Mail
    {
        protected string baseUrl = "https://www.1secmail.com";

        public readonly HttpClient client;

        public OneSecMail()
        {
            //example : https://github.com/riz4d/TempMail-Bot/blob/main/main.py

            client = new HttpClient();
        }
    
        public override string GetMailbox()
        {
            var jsonString = JsonConvert.SerializeObject(new { });
             
            HttpContent contentPost = new StringContent(jsonString, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(baseUrl + "/api/v1/?action=genRandomMailbox&count=1", contentPost).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<string>>(responseBody);

            if (result == null)
                return  "系統異常";

            return result.FirstOrDefault();
        }

        public override List<Message> GetMessages(string login = "demo", string domain = "1secmail.com")
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/v1/?action=getMessages&login=" + login + "&domain="+ domain).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<List<Message>>(responseBody);

            return result;
        }

        public Message GetMessage(string login = "demo ", string domain = "1secmail.com", int id = 639)
        {
            HttpResponseMessage response = client.GetAsync(baseUrl + "/api/v1/?action=readMessage&login=" + login + "&domain=" + domain + "&id=" + id).Result;

            var responseBody = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<Message>(responseBody);

            return result;
        }
    }
}
