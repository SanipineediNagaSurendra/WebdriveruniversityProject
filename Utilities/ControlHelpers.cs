using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityBDDFramework.Drivers;



namespace WebDriverUniversityBDDFramework.Utilities
{
    internal class ControlHelpers
    {


        public IWebElement FindElement(By locator)
        {
            return DriverFactory._driver.FindElement(locator);
        }

        public void SafeClick(By locator)
        {
            FindElement(locator).Click();
        }

        public void Url(string url)
        {
            DriverFactory._driver.Navigate().GoToUrl(url);
        }

        public void EnterText(By locator, string text)
        {
            FindElement(locator).SendKeys(text);
        }

        public void SwitchTab()
        {
            DriverFactory._driver.SwitchTo().Window(DriverFactory._driver.WindowHandles[1]);
        }

        public IReadOnlyCollection<IWebElement> FindElements(By locator)
        {
            return DriverFactory._driver.FindElements(locator);
        }

        public static string GetSelectedValue(By locator)
        {
            IWebElement element = DriverFactory._driver.FindElement(locator);
            SelectElement select = new SelectElement(element);
            return select.SelectedOption.Text.Trim();
        }
    }
}
