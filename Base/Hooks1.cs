using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using WebDriverUniversityBDDFramework.Drivers;

namespace WebDriverUniversityBDDFramework.Base
{
    [Binding]
    public sealed class Hooks1
    {

        private static IWebDriver driver;
       
        
        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {

            // Launching the chrome Browser 
            DriverFactory._driver = new ChromeDriver();

            //Manage Browser window
            DriverFactory._driver.Manage().Window.Maximize();

        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Close the Browser
            DriverFactory._driver.Quit();
        }
    }
}