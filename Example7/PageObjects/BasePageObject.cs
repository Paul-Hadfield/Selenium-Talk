using System;
using Example7.Common;
using OpenQA.Selenium;

namespace Example7.PageObjects
{
    public abstract class BasePageObject
    {
        protected IWebDriver driver;

        protected BasePageObject(IWebDriver driver)
        {
            this.driver = ReturnParameter.OrThrowIfNull(driver, nameof(driver));
        }
        
        protected T ManagedGet<T>(Func<T> func)
        {
            if (this.driver == null)
            {
                throw new ApplicationException("Unable to get page value, page is no longer valid.");
            }

            return func.Invoke();
        }
               
        public string Title { 
            get { return ManagedGet(() => driver.Title); }
        }
    }
}