using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Reqnroll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityBDDFramework.Drivers;
using WebDriverUniversityBDDFramework.Utilities;

namespace WebDriverUniversityBDDFramework.POM
{
    internal class Dropdown_CheckboxPage
    {
        private readonly ControlHelpers _controlHelpers;

        public Dropdown_CheckboxPage()
        {
            _controlHelpers = new ControlHelpers();
        }

        By Dropdown1 = By.Id("dropdowm-menu-1");
        By Dropdown2 = By.Id("dropdowm-menu-2");
        By Dropdown3 = By.Id("dropdowm-menu-3");

        public void SelectLanguages(DataTable table)
        {
            _controlHelpers.SwitchTab();
            
            List<string> languages = new List<string>();

            foreach (var row in table.Rows)
            {
                languages.Add(row["Dropdown Menu(s)"]);
            }

           

            
            SelectFromDropdown(Dropdown1, languages[0]);

            
            SelectFromDropdown(Dropdown2, languages[1]);

          
            SelectFromDropdown(Dropdown3, languages[2]);
        }

        public void VerifySelectedLanguages(DataTable table)
        {
            List<string> expected = new List<string>();

            foreach (var row in table.Rows)
            {
                expected.Add(row["Dropdown Menu(s)"]);
            }

            ClassicAssert.AreEqual(expected[0], ControlHelpers.GetSelectedValue(Dropdown1), "Dropdown 1 value mismatch");
            ClassicAssert.AreEqual(expected[1], ControlHelpers.GetSelectedValue(Dropdown2), "Dropdown 2 value mismatch");
            ClassicAssert.AreEqual(expected[2], ControlHelpers.GetSelectedValue(Dropdown3), "Dropdown 3 value mismatch");
        }
        private void SelectFromDropdown(By locator, string value)
        {
            IWebElement element = _controlHelpers.FindElement(locator);
            SelectElement select = new SelectElement(element);
            select.SelectByText(value);
        }
    }
}
