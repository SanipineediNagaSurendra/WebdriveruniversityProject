using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityBDDFramework.Drivers;
using WebDriverUniversityBDDFramework.Utilities;

namespace WebDriverUniversityBDDFramework.POM
{
    internal class WebsiteHomePage
    {
        private readonly ControlHelpers _controlHelpers;

        public WebsiteHomePage()
        {
            _controlHelpers = new ControlHelpers();
        }

        By HomePageHeaders(string element) => By.XPath($"//h1[contains(text(), '{element}')]");

        public void SafeClickHomePageHeaders(string element)
        {
            _controlHelpers.SafeClick(HomePageHeaders(element));
        }

        public void LaunchTheWebsite(string url)
        {
            _controlHelpers.Url(url);
        }


    }
}
