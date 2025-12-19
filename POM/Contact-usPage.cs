using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;
using WebDriverUniversityBDDFramework.Utilities;

namespace WebDriverUniversityBDDFramework.POM
{
    internal class Contact_usPage
    {

        private readonly ControlHelpers _controlHelpers;

        public Contact_usPage()
        {
            _controlHelpers = new ControlHelpers();
        }

        private readonly By firstName = By.CssSelector("input[name='first_name']");
        private readonly By lastName = By.CssSelector("input[name='last_name']");
        private readonly By email = By.CssSelector("input[name='email']");
        private readonly By comments = By.CssSelector("textarea[name='message']");

        By VerifyTextMessage(string message) => By.XPath($"//h1[text() = '{message}']");

        By FormButtons => By.Id("form_buttons");

        public void FillTheContactUsForm(DataTable table)
        {
            _controlHelpers.SwitchTab();
            var data = table.Rows[0];

            string fname = data["First Name"];
            string lname = data["Last Name"];
            string mail = data["Email Address"];
            string comment = data["Comments"];

            _controlHelpers.EnterText(firstName, fname);
            _controlHelpers.EnterText(lastName, lname);
            _controlHelpers.EnterText(email, mail);
            _controlHelpers.EnterText(comments, comment);

        }

        public void SafeClickSubmitButton(string btn)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            var buttonElements = _controlHelpers.FindElement(FormButtons).FindElements(By.TagName("input"));

            foreach (var element in buttonElements)
            {
                string value = element.GetAttribute("value");

                if (value.Equals(btn, StringComparison.OrdinalIgnoreCase))
                {
                    element.Click();
                    return;
                    
                }
            }
            stopwatch.Stop();
            throw new Exception($"Button with value '{btn}' not found!");
            
        }

        public void VerifyText(string text)
        {
            string actual = _controlHelpers.FindElement(VerifyTextMessage(text)).Text;

            Assert.That(text, Is.EqualTo(actual), "Text is not matched....");
        }


    }
}
