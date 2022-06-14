using System;
using System.Collections.Generic;
using System.Text;
using TestAutomationFramework;

namespace AppUnderTest.PageObjects
{
    public class ExtendedPO
    {
        private DriverHelper _driverHelper;

        public ExtendedPO(DriverHelper driverHelper)
        {
            _driverHelper = driverHelper;
        }

        public void NavigateSite(string site)
        {
            _driverHelper.Driver.Navigate().GoToUrl(site);
        }
    }
}
