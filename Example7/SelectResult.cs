using Xunit;

namespace Example7
{
    public class SelectResult : IClassFixture<SelectResultFixture>
    {
        private readonly SelectResultFixture testFixture;

        public SelectResult(SelectResultFixture testFixture)
        {
            this.testFixture = testFixture;
        }
        
        [Fact]
        public void CorrectTitle()
        {
            this.testFixture.RunAssert(() => Assert.Equal("Cheese - Wikipedia", this.testFixture.Page.Title));
        }
    }
}