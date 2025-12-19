using NUnit.Framework.Legacy;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using WebDriverUniversityBDDFramework.Utilities;

namespace WebDriverUniversityBDDFramework.POM
{
    internal class CheckboxPage
    {
        private readonly ControlHelpers _controlHelpers;


        public CheckboxPage()
        {
            _controlHelpers = new ControlHelpers();
        }


        By SelectCheckBox(string element) => By.XPath($"//label[contains(text(), '{element}' )]/child::input[@type = 'checkbox']");

        

        public void SelectTheCheckBox(DataTable table)
        {

            _controlHelpers.SwitchTab();

            foreach (var row in table.Rows)
            {

                string checkBoxes = row["Checkboxe(s)"];
                var checkbox = _controlHelpers.FindElement(SelectCheckBox(checkBoxes));

                if (!checkbox.Selected)
                {
                    checkbox.Click();
                }
                else
                {
                    Console.WriteLine($"{checkBoxes} CheckBox is already checked..");
                }
            }
        }
        public void VerifyGivenCheckBoxesIsSelected(DataTable dataTable)
        {
            foreach(var row in dataTable.Rows)
            {
                string checkBox = row["Checkboxe(s)"];

                var ele =  _controlHelpers.FindElement(SelectCheckBox(checkBox)).Selected;

                
                ClassicAssert.IsTrue(ele, "All checkboxes are not selected..");

                Console.WriteLine($"{checkBox} is selected checkboxes");

                
               
                
            }
        }
            
        
    }
}
