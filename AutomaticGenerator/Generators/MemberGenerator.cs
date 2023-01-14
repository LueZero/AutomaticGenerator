using AutomaticGenerator.Models.Generators.FaceBooks;
using AutomaticGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomNameGeneratorLibrary;

namespace AutomaticGenerator.Generators
{
    public abstract class MemberGenerator
    {
        protected TempMailService tempMailService;

        protected PersonNameGenerator personNameGenerator;

        protected Random gen = new Random();

        protected Chrome chrome;

        public List<User> Users;

        public MemberGenerator(TempMailService tempMailService, PersonNameGenerator personNameGenerator, Chrome chrome)
        {
            this.tempMailService = tempMailService;
            this.chrome = chrome;
            this.personNameGenerator = personNameGenerator;
            this.Users = new List<User>();
        }

        public abstract User GenerateUser();

        public DateTime GenerateRandomDate(int limitAge, int start = 1905)
        {
            DateTime startDate = new DateTime(start, 1, 1);

            int range = (DateTime.Today - startDate).Days;

            var randomDate = startDate.AddDays(gen.Next(range));

            if (((int)DateTime.Today.Year - (int)randomDate.Year) < limitAge)
                return GenerateRandomDate(limitAge);

            return randomDate;
        }

        public abstract void Register(int index);

        public abstract void Verify();

        public void Delete(int index)
        {
            Users.RemoveAt(index);
        }
    }
}

