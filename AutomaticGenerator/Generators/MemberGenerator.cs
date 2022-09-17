using AutomaticGenerator.Models.Generators.FaceBook;
using AutomaticGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator.Generators
{
    public abstract class MemberGenerator
    {
        protected TempMailService tempMailService;

        protected Chrome chrome;

        protected List<User> Users = new List<User>();

        public MemberGenerator()
        {
            tempMailService = new TempMailService();
            chrome = new Chrome();
        }

        public abstract User GenerateUser(int sort);

        public abstract void Register(int index);
    }
}

