using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Utils.Drivers
{
    internal static class PhantomJsWebDriver
    {
        internal static IWebDriver LoadPhantomJsDriver()
        {
            var driverService = PhantomJSDriverService.CreateDefaultService();
            driverService.IgnoreSslErrors = true;
            driverService.LoadImages = false;
            driverService.ProxyType = "none";
            driverService.HideCommandPromptWindow = true;

            var driver = new PhantomJSDriver(driverService);
            return driver;
        }



    }
}
