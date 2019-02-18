using Example8.Common;
using Xunit;

namespace Example8.HomePage
{
    public abstract class BaseHomePageTests
    {
        protected readonly BaseHomePageFixture testFixture;

        protected BaseHomePageTests(BaseHomePageFixture testPageFixture)
        {
            this.testFixture = ReturnParameter.OrThrowIfNull(testPageFixture, nameof(testPageFixture));

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