using AppUnderTest.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppUnderTest.BusinessObjects
{
    public class ExtendedBO
    {
        private readonly ExtendedPO _extendedPO;

        public ExtendedBO(ExtendedPO extendedPO)
        {
            _extendedPO = extendedPO;
        }

        public void GoToSite()
        {
            _extendedPO.NavigateSite("http://eaapp.somee.com/");
        }
    }
}
