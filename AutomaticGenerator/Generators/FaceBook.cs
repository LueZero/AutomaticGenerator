using AutomaticGenerator.Helpers;
using AutomaticGenerator.Models.Generators.FaceBook;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
        public FaceBook(): base()
        {
        }

        public override User GenerateUser(int index)
        {
            var email = tempMailService.GetCryptogSecMailbox();
            var user =  new User() 
            {
                Index = index,
                Lastname = "lin",
                FirstName = "luezero",
                Sex = 1,
                Email = email,
                Account = email,
                Password = Information.RandomString(20, true),
                CellPhone = "0912345678",
                Year = "1993",
                Month = "11",
                Day = "10",
            };

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

            string lastname = user.Lastname;
            string firstname = user.FirstName;
            string sex = (user.Sex == 1 ? "1" : "2");
            string account = user.Account;
            string email = user.Email;
            string password = user.Password;
            string year = user.Year;
            string month = user.Month;
            string day = user.Day;

            driver.FindElement(By.XPath("//input[@name='lastname']")).SendKeys(lastname);
            driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys(firstname);
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
