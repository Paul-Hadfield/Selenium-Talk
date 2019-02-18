using Example8.Common;
using Xunit;

namespace Example8.ResultsPage
{
    public abstract class BaseResultsPageTests
    {
        protected readonly BaseResultsPageFixture testFixture;

        protected BaseResultsPageTests(BaseResultsPageFixture testFixture)
        {
            this.testFixture = ReturnParameter.OrThrowIfNull(testFixture, nameof(testFixture));

        }
        
        [Fact]
        public void CorrectTitle()
        {
            this.testFixture.RunAssert(() => Assert.Equal(this.testFixture.Page.ExpectedTitle, this.testFixture.Page.ActualTitle));
        }
        
        [Fact]
        public void CorrectUrl()
        {
            this.testFixture.RunAssert(() => Assert.StartsWith(this.testFixture.Page.ExpectedUrl, this.testFixture.Page.ActualUrl));
        }
    }
}