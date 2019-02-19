using Xunit;

namespace Example7
{
    public class SelectResultTests : IClassFixture<SelectResultFixture>
    {
        private readonly SelectResultFixture testFixture;

        public SelectResultTests(SelectResultFixture testFixture)
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