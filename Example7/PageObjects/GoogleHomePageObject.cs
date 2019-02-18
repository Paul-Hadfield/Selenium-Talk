using System;
using Example7.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example7.PageObjects
{
    public class GoogleHomePageObject : BasePageObject
    {
        private GoogleHomePageObject(IWebDriver driver) : base(driver)
        {
            if (string.Compare("Google", this.driver.Title, StringComparison.OrdinalIgnoreCase) != 0)
            {
                throw new ApplicationException("Can not create page object, driver not valid");
            }
        }

        public static GoogleHomePageObject Load(IWebDriver driver)
        {
            Throw.IfNull(driver, nameof(driver));
            
            driver.Navigate().GoToUrl("http://www.google.com/");
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(d => d.Title.Equals("Google", StringComparison.OrdinalIgnoreCase));

            return new GoogleHomePageObject(driver);
        }
        
        public GoogleResultsPageObject Search(string searchValue) 
        {
            try
            {
                Throw.IfNullEmptyOrWhiteSpace(searchValue, nameof(searchValue));
                
                var query = driver.FindElement(By.Name("q"));
                query.SendKeys(searchValue);
                query.Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                            .Until(d => d.Title.StartsWith("cheese", StringComparison.OrdinalIgnoreCase));

                return new GoogleResultsPageObject(this.driver);
            }
            finally
            {
                this.driver = null;
            }
        }   
    }
}