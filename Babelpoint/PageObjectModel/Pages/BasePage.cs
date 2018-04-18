
using OpenQA.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModel.Utils.Selenium;

namespace PageObjectModel.Pages
{
    public class BasePage : Page
    {
        public IWebDriver Driver { get; internal set; }

        public void AccessMainEnterPoint()
        {
            Browser().Navigate().GoToUrl(Settings.BaseUrl);
            Browser().Manage().Window.Maximize();
            Console.WriteLine(Settings.WelcomeMessage);
        }

    }
}
