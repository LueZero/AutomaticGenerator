﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutomaticGenerator.Services;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace AutomaticGenerator
{
    public partial class Form1 : Form
    {
        private TempMailService _tempMailService;

        private IWebDriver _driver = null;

        public Form1()
        {
            InitializeComponent();
            _tempMailService = new TempMailService(new OneSecMail());

            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void createAccount_Click(object sender, EventArgs e)
        {
            var mails = _tempMailService.GetMailbox();
            var index = dataGridView1.Rows.Add();

            dataGridView1.Rows[index].Cells["sort"].Value = index + 1;
            dataGridView1.Rows[index].Cells["lastname"].Value = "劉";
            dataGridView1.Rows[index].Cells["firstName"].Value = "倫德";
            dataGridView1.Rows[index].Cells["email"].Value = mails;
            dataGridView1.Rows[index].Cells["account"].Value = mails;
            dataGridView1.Rows[index].Cells["password"].Value = Mmeber.RandomString(20, true);
            dataGridView1.Rows[index].Cells["cellPhone"].Value = "0912345678";
            dataGridView1.Rows[index].Cells["register"].Value = "註冊";
            dataGridView1.Rows[index].Cells["year"].Value = "1993";
            dataGridView1.Rows[index].Cells["month"].Value = "11";
            dataGridView1.Rows[index].Cells["day"].Value = "10";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell == null || dataGridView1.CurrentCell.Value == null || e.RowIndex == -1) 
                return;

            if (e.ColumnIndex == 11)
            {
                var DeviceDriver = ChromeDriverService.CreateDefaultService();
                DeviceDriver.HideCommandPromptWindow = true;

                ChromeOptions options = new ChromeOptions();
                options.AddArguments("--disable-infobars");
                _driver = new ChromeDriver(DeviceDriver, options);

                _driver.Manage().Window.Maximize();
                _driver.Navigate().GoToUrl("https://www.facebook.com/campaign/landing.php");
                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                string lastname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                string firstname = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                string sex = (Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value) == "男生" ? "1" : "2");
                string account = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                string email = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                string password = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[6].Value);

                string year = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                string month = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                string day = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[10].Value);

                _driver.FindElement(By.XPath("//input[@name='lastname']")).SendKeys(lastname);
                _driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys(firstname);
                _driver.FindElement(By.XPath("//input[@name='reg_email__']")).SendKeys(email);
                Thread.Sleep(1000);
                _driver.FindElement(By.XPath("//input[@name='reg_email_confirmation__']")).SendKeys(email);
                _driver.FindElement(By.XPath("//input[@name='reg_passwd__']")).SendKeys(password);

                IWebElement yearElement = _driver.FindElement(By.XPath("//select[@id='year']"));
                SelectElement yearSelectElement = new SelectElement(yearElement);
                yearSelectElement.SelectByValue(year);

                Thread.Sleep(1000);
                IWebElement monthElement = _driver.FindElement(By.XPath("//select[@id='month']"));
                SelectElement monthSelectElement = new SelectElement(monthElement);
                monthSelectElement.SelectByValue(month);

                Thread.Sleep(1000);
                IWebElement dayElement = _driver.FindElement(By.XPath("//select[@id='day']"));
                SelectElement daySelectElement = new SelectElement(dayElement);
                daySelectElement.SelectByValue(day);

                Thread.Sleep(1000);
                IWebElement sexElement = _driver.FindElement(By.XPath("//input[@name='sex'][@value='"+ sex + "']"));
                sexElement.Click();

                Thread.Sleep(1000);
                IWebElement webSubmitElement = _driver.FindElement(By.XPath("//button[@name='websubmit']"));
                webSubmitElement.Click();
            }
        }
    }
}
