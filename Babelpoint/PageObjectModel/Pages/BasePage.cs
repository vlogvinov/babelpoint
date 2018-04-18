
using OpenQA.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModel.Utils.Selenium;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace PageObjectModel.Pages
{
    public class BasePage : Page
    {
        public IWebDriver Driver { get; internal set; }
        public string GetTitle => Driver.Title;
        public string GetUrl => Driver.Url;
        public string GetText => Driver.PageSource;

        public void AccessMainEnterPoint()
        {
            Browser().Navigate().GoToUrl(Settings.BaseUrl);
            Browser().Manage().Window.Maximize();
            Console.WriteLine(Settings.WelcomeMessage);
        }

        public void ValidatePageTitle(string expectedTitle)
        {
            var titleToValidate = Driver.Title.Contains(expectedTitle);
            Assert.IsTrue(titleToValidate, ":: This is not the expected title");
            Console.WriteLine(":: the title of the site is " + GetTitle);
        }

        public void ValidatePageUrl(string expectedUrl)
        {
            var urlToValidate = Driver.Url.Contains(expectedUrl);
            Assert.IsTrue(urlToValidate, ":: This is not the expected Url");
            Console.WriteLine(":: the Url of the site is " + GetUrl);
        }

        public void ValidateTextInPageSource(string expectedText)
        {
            var textToValidate = Driver.PageSource.Contains(expectedText);
            Assert.IsTrue(textToValidate, ":: This is not the expected text");
            Console.WriteLine(":: The text {} is in the PageSource" + expectedText);
        }

        public void ValidateMultipleTextInPageSource(Table table)
        {
            foreach (var row in table.Rows)
            {
                var textToValidate = row["expectedText"];
                Assert.IsTrue(Driver.PageSource.Contains(textToValidate), "This is not the expected text!");
                Console.WriteLine(":: The text {0} is in the PageSource", textToValidate);
            }
        }



    }
}
