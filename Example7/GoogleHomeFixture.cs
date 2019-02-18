using Example7.PageObjects;

namespace Example7
{
    public class GoogleHomeFixture : BaseFixture
    {
        public GoogleHomeFixture()
        {
            this.Page = GoogleHomePageObject
                .Load(this.driver);
        }
        
        public GoogleHomePageObject Page { get; }
    }
}