using System;
using OpenQA.Selenium;

namespace Example7.PageObjects
{
    public class GoogleResultsPageObject : BasePageObject
    {
        public GoogleResultsPageObject(IWebDriver driver) : base(driver)
        {            
            if(!this.driver.Title.EndsWith("- Google Search", StringComparison.OrdinalIgnoreCase))
            {
                throw new ApplicationException("Can not create page object, driver not valid");
            }
        }

        public string FirstResult
        {
            get { return ManagedGet(() => driver.FindElement(By.XPath("//h3[@class='LC20lb']")).Text); }
        }
        public string AttributeValue  { 
            get { return ManagedGet(() => driver.FindElement(By.Id("hdtb-msb-vis")).FindElement(By.XPath("div[contains(text(), 'All')]")).GetAttribute("aria-selected")); }
        }

        public WikipediaPageObject WikipediaResult(string linkText)
        {
            try
            {
                this.driver.FindElement(By.XPath($"//h3[contains(text(), '{linkText}')]")).Click();
                return new WikipediaPageObject(this.driver);
            }
            finally
            {
                this.driver = null;
            }
        }
    }
}