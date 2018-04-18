using PageObjectModel.Pages;
using PageObjectModel.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Steps
{
    [Binding]
    public sealed class BaseScenariousSteps : BaseSteps
    {
        [Given(@"I navigate to the homepage")]
        public void GivenINavigateToTheHomepage()
        {
            InstanceOf<BasePage>().AccessMainEnterPoint();
        }

    }
}
