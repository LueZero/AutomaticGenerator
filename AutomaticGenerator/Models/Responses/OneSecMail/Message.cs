using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Models.Responses.OneSecMail
{
    public class Message
    {
        public string Id { get; set; }

        public string From { get; set; }

        public string Subject { get; set; }

        public string Date { get; set; }

        public string Body { get; set; }

        public string TextBody { get; set; }

        public string HtmlBody { get; set; }
    }
}
