using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticGenerator
{
    public class Chrome
    {
        private IWebDriver driver;

        private Proxy proxy;

        public Chrome SetChromeDriver()
        {
            var DeviceDriver = ChromeDriverService.CreateDefaultService();

            DeviceDriver.HideCommandPromptWindow = true;

            SetProxy();

            driver = new ChromeDriver(DeviceDriver, SetChromeOptions());

            return this;
        }

        public void SetProxy()
        {
            string proxyUrlFormat = "http://zend2.com/bro.php?u={0}&b=12&f=norefer";

            proxy = new Proxy();
            proxy.HttpProxy = proxyUrlFormat;
        }

        public ChromeOptions SetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();

            options.Proxy = proxy;
            options.AddArgument("--incognito");
            options.AddArgument("disable-infobars");

            return options;
        }

        public IWebDriver GetDriver()
        {
            return driver;
        }
    }
}
