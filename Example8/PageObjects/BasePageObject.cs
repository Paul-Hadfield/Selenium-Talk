using System;
using Example8.Common;
using OpenQA.Selenium;

namespace Example8.PageObjects
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

        public string ActualUrl
        {
            get { return ManagedGet(() => this.driver.Url); }
        }

        public string ActualTitle
        {
            get { return ManagedGet(() => this.driver.Title); }
        }
        
        public abstract string ExpectedUrl { get; }

        public abstract string ExpectedTitle { get; }
    }
}