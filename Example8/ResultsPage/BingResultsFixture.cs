using Example8.PageObjects.HomePage;

namespace Example8.ResultsPage
{
    public class BingResultsFixture : BaseResultsPageFixture
    {
        public BingResultsFixture()
        {
            this.Page = BingHomePageObject
                .Load(this.driver).Search("Cheese");
        }
        
    }
}