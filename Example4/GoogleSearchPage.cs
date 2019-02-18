using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example4
{
    public class GoogleSearchPage
    {
        private IWebDriver driver;

        private GoogleSearchPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public string Title => SafeSelect(() => this.driver.Title);
        public string FirstResult => SafeSelect(() => driver.FindElement(By.TagName("h3")).Text);

        public bool AllTabSelected => SafeSelect(() =>
            string.Compare(
                driver.FindElement(By.Id("hdtb-msb-vis")).FindElement(By.XPath("div[contains(text(), 'All')]"))
                    .GetAttribute("aria-selected"), "true", StringComparison.OrdinalIgnoreCase) == 0);

        public static GoogleSearchPage Load(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://www.google.com/");
            
            return new GoogleSearchPage(driver);
        }

        public GoogleSearchPage Search(string searchTerm)
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

            return this;
        }
        
        private static T SafeSelect<T>(Func<T> func)
        {
            try
            {
                return func.Invoke();
            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
}