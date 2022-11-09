using AutomaticGenerator.Enums;
using AutomaticGenerator.Helpers;
using AutomaticGenerator.Models.Generators.FaceBook;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using RandomNameGeneratorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomaticGenerator.Generators
{
    public class FaceBook : MemberGenerator
    {
        public FaceBook(TempMailService tempMailService, PersonNameGenerator personNameGenerator, Chrome chrome) : base(tempMailService, personNameGenerator, chrome)
        {
        }

        public override User GenerateUser()
        {
            var user = new User();

            var lastName = personNameGenerator.GenerateRandomLastName();
            var firstName = personNameGenerator.GenerateRandomFirstName();
            var email = tempMailService.GetCryptogSecMailbox();
            
            var date = GenerateRandomDate(18, 1993);

            user.LastName = lastName;
            user.FirstName = firstName;
            user.Sex = SexType.男性;
            user.Email = email;
            user.Account = email;
            user.Password = Information.RandomString(20, true);
            user.CellPhone = "";
            user.Year = date.Year.ToString();
            user.Month = date.Month.ToString();
            user.Day = date.Day.ToString();

            Users.Add(user);

            return user;
        }

        public override void Register(int index)
        {
            var user = Users[index];

            var driver =  chrome.SetChromeDriver().GetDriver();

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/campaign/landing.php");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            string lastName = user.LastName;
            string firstName = user.FirstName;
            int sex = (int)user.Sex;
            string account = user.Account;
            string email = user.Email;
            string password = user.Password;
            string year = user.Year;
            string month = user.Month;
            string day = user.Day;

            driver.FindElement(By.XPath("//input[@name='lastname']")).SendKeys(lastName);
            driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys(firstName);
            driver.FindElement(By.XPath("//input[@name='reg_email__']")).SendKeys(email);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@name='reg_email_confirmation__']")).SendKeys(email);
            driver.FindElement(By.XPath("//input[@name='reg_passwd__']")).SendKeys(password);

            IWebElement yearElement = driver.FindElement(By.XPath("//select[@id='year']"));
            SelectElement yearSelectElement = new SelectElement(yearElement);
            yearSelectElement.SelectByValue(year);

            Thread.Sleep(1000);
            IWebElement monthElement = driver.FindElement(By.XPath("//select[@id='month']"));
            SelectElement monthSelectElement = new SelectElement(monthElement);
            monthSelectElement.SelectByValue(month);

            Thread.Sleep(1000);
            IWebElement dayElement = driver.FindElement(By.XPath("//select[@id='day']"));
            SelectElement daySelectElement = new SelectElement(dayElement);
            daySelectElement.SelectByValue(day);

            Thread.Sleep(1000);
            IWebElement sexElement = driver.FindElement(By.XPath("//input[@name='sex'][@value='" + sex + "']"));
            sexElement.Click();

            Thread.Sleep(1000);
            IWebElement webSubmitElement = driver.FindElement(By.XPath("//button[@name='websubmit']"));
            webSubmitElement.Click();
        }
    }
}
