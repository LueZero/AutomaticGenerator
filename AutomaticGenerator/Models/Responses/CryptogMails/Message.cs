using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Models.Responses.CryptogMails
{
    public class Message
    {
        public string Id { get; set; }

        public Sender Sender { get; set; }

        public string Subject { get; set; }

        public string Created_At { get; set; }
    }
}
