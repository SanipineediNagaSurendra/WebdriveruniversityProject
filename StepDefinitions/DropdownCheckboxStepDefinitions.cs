using System;
using Reqnroll;
using WebDriverUniversityBDDFramework.POM;

namespace WebDriverUniversityBDDFramework.StepDefinitions
{
    [Binding]
    public class DropdownCheckboxStepDefinitions
    {
        WebsiteHomePage homePage = new WebsiteHomePage();
        Dropdown_CheckboxPage droppage = new Dropdown_CheckboxPage();
        CheckboxPage checkPage = new CheckboxPage();    

        [Given("The user launches the website {string}")]
        public void GivenTheUserLaunchesTheWebsite(string p0)
        {
            homePage.LaunchTheWebsite(p0);
        }

        [When("user select the {string} header")]
        public void WhenUserSelectTheHeader(string dROPDOWN)
        {
            homePage.SafeClickHomePageHeaders(dROPDOWN);
        }

        [When("user select the Dropdown Menu")]
        public void WhenUserSelectTheDropdownMenu(DataTable dataTable)
        {
            droppage.SelectLanguages(dataTable);
        }

        [Then("user should verify given languages selected or not")]
        public void ThenUserShouldVerifyGivenLanguagesSelectedOrNot(DataTable dataTable)
        {
            droppage.VerifySelectedLanguages(dataTable);
        }


        //checkbox feature

        [When("user select the Checkbox Menu'S")]
        public void WhenUserSelectTheCheckboxMenuS(DataTable dataTable)
        {
            checkPage.SelectTheCheckBox(dataTable);
        }

        [Then("user should verify given checkbox selected or not")]
        public void ThenUserShouldVerifyGivenCheckboxSelectedOrNot(DataTable dataTable)
        {
            checkPage.VerifyGivenCheckBoxesIsSelected(dataTable);
        }

    }
}
