using Example8.PageObjects.HomePage;

namespace Example8.ResultsPage
{
    public class GoogleResultsFixture : BaseResultsPageFixture
    {
        public GoogleResultsFixture()
        {
            this.Page = GoogleHomePageObject
                .Load(this.driver).Search("Cheese");
        }
        
    }
}