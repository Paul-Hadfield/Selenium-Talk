using System;
using Example8.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example8.PageObjects.ResultsPage
{
    public class DuckDuckGoResultsPageObject : BaseResultsPageObject
    {
        public DuckDuckGoResultsPageObject(IWebDriver driver, string searchValue) : base(driver, searchValue)
        {
            if (string.Compare(this.ExpectedTitle, this.driver.Title, StringComparison.OrdinalIgnoreCase) != 0)
            {
                throw new ApplicationException("Can not create page object, driver not valid");
            }
        }
        
        public override string ExpectedUrl => "https://duckduckgo.com";

        public override string ExpectedTitle => $"{this.searchValue} at DuckDuckGo";
    }
}