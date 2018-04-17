using PageObjectModel.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Pages
{
    public abstract class Page
    {
        protected T InstanceOf<T>() where T : BasePage, new()
        {
            var pageClass = new T {Driver = Driver.Browser()};
            return pageClass;
        }
    }
}
