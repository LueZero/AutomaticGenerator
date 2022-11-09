using AutomaticGenerator.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Models.Generators.FaceBook
{
    public class User
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public SexType Sex { get; set; }

        public string Email { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string CellPhone { get; set; }

        public string Year { get; set; }

        public string Month { get; set; }

        public string Day { get; set; }
    }
}
