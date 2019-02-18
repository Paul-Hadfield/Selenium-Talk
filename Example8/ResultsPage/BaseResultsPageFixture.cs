using Example8.PageObjects.ResultsPage;

namespace Example8.ResultsPage
{
    public abstract class BaseResultsPageFixture : BaseFixture
    {
        public BaseResultsPageObject Page { get; protected set; }
    }
}