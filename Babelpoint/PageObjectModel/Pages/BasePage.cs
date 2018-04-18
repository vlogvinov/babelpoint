﻿
using OpenQA.Selenium;
using static PageObjectModel.Utils.Selenium.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PageObjectModel.Utils.Selenium;
using NUnit.Framework;

namespace PageObjectModel.Pages
{
    public class BasePage : Page
    {
        public IWebDriver Driver { get; internal set; }
        public string GetTitle => Driver.Title;

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



    }
}
