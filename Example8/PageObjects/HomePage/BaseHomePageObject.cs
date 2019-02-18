using OpenQA.Selenium;

namespace Example8.PageObjects.HomePage
{
    public abstract class BaseHomePageObject : BasePageObject
    {
        protected BaseHomePageObject(IWebDriver driver) : base(driver)
        {
        }
    }
}