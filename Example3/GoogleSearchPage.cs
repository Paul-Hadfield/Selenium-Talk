using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example3
{
    public class GoogleSearchPage
    {
        private IWebDriver driver;

        private GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public static GoogleSearchPage Load(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            
            return new GoogleSearchPage(driver);
        }

        public void Search(string searchTerm)
        {
            var query = driver.FindElement(By.Name("q"));

               
            // Enter something to search for
            query.SendKeys(searchTerm);

            // Now submit the form. WebDriver will find the form for us from the element
            query.Submit();

            // Google's search is rendered dynamically with JavaScript.
            // Wait for the page to load, timeout after 10 seconds
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d => d.Title.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase));
        }

        public string Title => this.driver.Title;
    }
}