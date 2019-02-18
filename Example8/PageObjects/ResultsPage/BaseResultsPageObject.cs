using OpenQA.Selenium;

namespace Example8.PageObjects.ResultsPage
{
    public abstract class BaseResultsPageObject : BasePageObject
    {
        protected readonly string searchValue;
        
        protected BaseResultsPageObject(IWebDriver driver, string searchValue) : base(driver)
        {
            this.searchValue = searchValue;
        }
    }
}