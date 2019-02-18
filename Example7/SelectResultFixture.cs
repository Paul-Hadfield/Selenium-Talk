using Example7.PageObjects;

namespace Example7
{
    public class SelectResultFixture : BaseFixture
    {
        public SelectResultFixture()
        {
            this.Page = new WikipediaPageObject(GoogleHomePageObject
                .Load(this.driver)
                .Search("Cheese")
                .SelectLink("Cheese - Wikipedia"));    
        }
        
        public WikipediaPageObject Page { get; }
    }
}