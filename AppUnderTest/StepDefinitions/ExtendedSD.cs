using AppUnderTest.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestAutomationFramework;

namespace AppUnderTest.StepDefinitions
{
    [Binding]
    public class ExtendedSD
    {
        private readonly ExtendedBO _extendedBO;

        public ExtendedSD(ExtendedBO extendedBO)
        {
            _extendedBO = extendedBO;
        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            _extendedBO.GoToSite();
        }
    }
}
