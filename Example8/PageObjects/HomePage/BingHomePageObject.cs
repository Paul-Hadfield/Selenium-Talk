using System;
using Example8.Common;
using Example8.PageObjects.ResultsPage;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example8.PageObjects.HomePage
{
    public class BingHomePageObject : BaseHomePageObject
    {
        private const string Url = "http://www.bing.co.uk";
        
        private const string Title = "Bing";
        
        private BingHomePageObject(IWebDriver driver) : base(driver)
        {
            if (string.Compare(Title, this.driver.Title, StringComparison.OrdinalIgnoreCase) != 0)
            {
                throw new ApplicationException("Can not create page object, driver not valid");
            }
        }

        public static BingHomePageObject Load(IWebDriver driver)
        {
            Throw.IfNull(driver, nameof(driver));
            
            driver.Navigate().GoToUrl(Url);
            new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                .Until(d => d.Title.Equals(Title, StringComparison.OrdinalIgnoreCase));

            return new BingHomePageObject(driver);
        }
        
        public BaseResultsPageObject Search(string searchValue) 
        {
            try
            {
                Throw.IfNullEmptyOrWhiteSpace(searchValue, nameof(searchValue));
                
                var query = driver.FindElement(By.Name("q"));
                query.SendKeys(searchValue);
                query.Submit();

                new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                    .Until(d => d.Title.StartsWith("cheese", StringComparison.OrdinalIgnoreCase));

                return new BingResultsPageObject(this.driver, searchValue);
            }
            finally
            {
                this.driver = null;
            }
        }

        public bool BingLogoShown()
        {
            return base.ManagedGet(() => this.driver.FindElement(By.ClassName("hp_sw_logo")) != null);
        }
        
        public override string ExpectedUrl => "https://www.bing.com";

        public override string ExpectedTitle => Title;
    }
}