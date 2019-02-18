using Xunit;

namespace Example6
{
    public class GoogleSearch : IClassFixture<GoogleSearchFixture>
    {
        private readonly GoogleSearchFixture testFixture;

        public GoogleSearch(GoogleSearchFixture testFixture)
        {
            this.testFixture = testFixture;
        }

        [Fact]
        public void FirstResultIsWikipedia()
        {
            Assert.Equal("Cheese - Wikipedia", this.testFixture.FirstResult);
        }

        [Fact]
        public void CorrectTitle()
        {
            Assert.Equal("Cheese - Google Search", this.testFixture.Title);
        }

        [Fact]
        public void ShowingAll()
        {
            Assert.True(this.testFixture.AllTabSelected);
        }
    }
}