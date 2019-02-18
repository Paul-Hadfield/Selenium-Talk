using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Example6
{
    public class GoogleSearchFixture
    {
        public GoogleSearchFixture()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .Build();
            
            using (var driver = WebDriverFactory.Create(config))
            {
                var searchPage = GoogleSearchPage
                    .Load(driver)
                    .Search("Cheese");

                this.Title = searchPage.Title;
                this.FirstResult = searchPage.FirstResult;
                this.AllTabSelected = searchPage.AllTabSelected;
            }
        }

        public string Title { get; }

        public string FirstResult { get; }
        
        public bool AllTabSelected { get; }
    }
}