using PageObjectModel.Utils.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace PageObjectModel.Utils.Hooks
{
    internal static class ScenariousHooks
    {
        [BeforeScenario]
        internal static void StartWebDriver()
        {
            if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("PhantomJs"))
            {
                DriverController.Instance.StartPhantomJs();
            }
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Chrome"))
            {
                DriverController.Instance.StartChrome();
            }
            else if (ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug"))
            {
                DriverController.Instance.StartChrome();
            }
            else
            {
                DriverController.Instance.StartChrome();
            }
        }

        [AfterScenario]
        internal static void StopWebDriver()
        {
            if (!ScenarioContext.Current.ScenarioInfo.Tags.Contains("Debug"))
            {
                DriverController.Instance.StopWebDriver();
            }
        }
    }
}