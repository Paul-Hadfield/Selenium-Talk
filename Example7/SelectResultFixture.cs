using Example7.PageObjects;

namespace Example7
{
    public class SelectResultFixture : BaseFixture
    {
        public SelectResultFixture()
        {
            this.Page = GoogleHomePageObject
                .Load(this.driver)
                .Search("Cheese")
                .WikipediaResult("Cheese - Wikipedia");    
        }
        
        public WikipediaPageObject Page { get; }
    }
}