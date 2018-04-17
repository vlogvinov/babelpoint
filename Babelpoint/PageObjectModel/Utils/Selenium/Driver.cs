using OpenQA.Selenium;
using PageObjectModel.Utils.Drivers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Selenium
{
    [Binding]
    internal class Driver
    {
        internal static IWebDriver Browser
            => DriverController.Instance.WebDriver;
    }
}
