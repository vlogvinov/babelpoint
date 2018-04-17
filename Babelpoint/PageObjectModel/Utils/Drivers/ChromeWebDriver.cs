using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Utils.Drivers
{
    internal static class ChromeWebDriver
    {
        internal static IWebDriver LoadChromeDriver()
        {
            var driverService = ChromeDriverService.CreateDefaultService();
            driverService.HideCommandPromptWindow = true;

            var options = new ChromeOptions();
            options.AddArgument("--disable-extentions");

            ChromeDriver driver = new ChromeDriver(driverService, options);
            return driver;

        }
    }
}
