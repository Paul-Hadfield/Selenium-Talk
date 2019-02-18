using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Xunit;

namespace Example5
{
    public class GoogleSearch
    {
        private readonly string title;
        private readonly string firstResult;
        private readonly bool allTabSelected;

        public GoogleSearch()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .Build();
            
            using (var driver = WebDriverFactory.Create(config))
            {
                var searchPage = GoogleSearchPage
                    .Load(driver)
                    .Search("Cheese");

                this.title = searchPage.Title;
                this.firstResult = searchPage.FirstResult;
                this.allTabSelected = searchPage.AllTabSelected;
            }
        }

        [Fact]
        public void CorrectTitle()
        {
            Assert.Equal("Cheese - Google Search", this.title);
        }

        [Fact]
        public void FirstResultIsWikipedia()
        {
            Assert.Equal("Cheese - Wikipedia", this.firstResult);            
        }

        [Fact]
        public void ShowingAll()
        {
            Assert.True(this.allTabSelected);
        }
    }
}