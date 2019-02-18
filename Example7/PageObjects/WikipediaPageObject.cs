using System;
using OpenQA.Selenium;

namespace Example7.PageObjects
{
    public class WikipediaPageObject : BasePageObject
    {
        public WikipediaPageObject(IWebDriver driver) : base(driver)
        {            
            if(!this.driver.Title.Equals("Cheese - Wikipedia", StringComparison.OrdinalIgnoreCase))
            {
                throw new ApplicationException("Can not create page object, driver not valid");
            }
        }
    }
}