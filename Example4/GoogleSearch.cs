using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Example4
{
    public class GoogleSearch
    {
        [Fact]
        public void CheeseSearch()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .Build();
            
            using (var driver = WebDriverFactory.Create(config))
            {
                var searchPage = GoogleSearchPage
                    .Load(driver)
                    .Search("Cheese");
                
                Assert.Equal("Cheese - Google Search", searchPage.Title);
                Assert.Equal("Cheese - Wikipedia", searchPage.FirstResult);            
                Assert.True(searchPage.AllTabSelected);
            }
        }
    }
}