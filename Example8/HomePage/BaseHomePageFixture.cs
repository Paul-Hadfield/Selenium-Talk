using Example8.PageObjects.HomePage;

namespace Example8.HomePage
{
    public abstract class BaseHomePageFixture : BaseFixture
    {
        public BaseHomePageObject Page { get; protected set; }
    }
}