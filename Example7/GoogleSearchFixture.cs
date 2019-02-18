using Example7.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace Example7
{
    public class GoogleSearchFixture : BaseFixture
    {
        public GoogleSearchFixture()
        {
            this.Page = GoogleHomePageObject
                                .Load(this.driver)
                                .Search("Cheese");
        }

        public GoogleResultsPageObject Page { get; }
    }
}