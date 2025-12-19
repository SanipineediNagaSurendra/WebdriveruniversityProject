using System;
using OpenQA.Selenium;
using Reqnroll;
using WebDriverUniversityBDDFramework.POM;

namespace WebDriverUniversityBDDFramework.StepDefinitions
{
    [Binding]
    public class ContactUsStepDefinitions
    {
        Contact_usPage page = new Contact_usPage();
        WebsiteHomePage webHomePage = new WebsiteHomePage();

        [Given("User launches the website {string}")]
        public void GivenUserLaunchesTheWebsite(string p0)
        {
            webHomePage.LaunchTheWebsite(p0);
            Thread.Sleep(4000);
        }

        [When("user selects the {string} header")]
        public void WhenUserSelectsTheHeader(string p0)
        {
            webHomePage.SafeClickHomePageHeaders(p0);
            Thread.Sleep(4000);
        }

        [When("user enters the details in contact-us form")]
        public void WhenUserEntersTheDetailsInContact_UsForm(DataTable dataTable)
        {
            page.FillTheContactUsForm(dataTable);
            Thread.Sleep(4000);
        }

        [When("user click on the {string} Button")]
        public void WhenUserClickOnTheButton(string submit)
        {
            page.SafeClickSubmitButton(submit);
            Thread.Sleep(4000);
        }

        [Then("the user verifies the confirmation message {string}")]
        public void ThenTheUserVerifiesTheConfirmationMessage(string p0)
        {
            page.VerifyText(p0);
            Thread.Sleep(4000);
        }
    }
}
