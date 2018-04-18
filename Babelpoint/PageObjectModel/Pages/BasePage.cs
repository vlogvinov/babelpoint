
using OpenQA.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
    public class BasePage : Page
    {
        public IWebDriver Driver { get; internal set; }

        public void AccessMainEnterPoint()
        {
            const string url = "https://www.wikipedia.org/";
            Browser().Navigate().GoToUrl(url);
           
        }

    }
}
