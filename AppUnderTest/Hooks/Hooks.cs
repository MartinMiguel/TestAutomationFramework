using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace TestAutomationFramework.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private DriverHelper _driverHelper;

        public Hooks(DriverHelper driverHelper) {
            _driverHelper = driverHelper;
        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArguments("start-maximized");
            option.AddArguments("disable-gpu");
            string driverPath = System.IO.Directory.GetCurrentDirectory() + "\\Drivers\\";
            _driverHelper.Driver = new ChromeDriver(@driverPath,option);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driverHelper.Driver.Quit();
        }
    }
}
