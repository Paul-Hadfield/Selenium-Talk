using Example8.PageObjects.HomePage;

namespace Example8.HomePage
{
    public class GoogleHomePageFixture : BaseHomePageFixture
    {
        public GoogleHomePageFixture()
        {
            this.Page = GoogleHomePageObject
                .Load(this.driver);
        }
        
    }
}