using System;
using Xunit;

namespace Example7
{
    public class GoogleSearchTests : IClassFixture<GoogleSearchFixture>
    {
        private readonly GoogleSearchFixture testFixture;

        public GoogleSearchTests(GoogleSearchFixture testFixture)
        {
            this.testFixture = testFixture;
        }

        [Fact]
        public void FirstResultIsWikipedia()
        {
            this.testFixture.RunAssert(() => Assert.Equal("Cheese - Wikipedia", this.testFixture.Page.FirstResult));
        }

        [Fact]
        public void CorrectTitle()
        {
            this.testFixture.RunAssert(() => Assert.Equal("Cheese - Google Search", this.testFixture.Page.Title));
        }

        [Fact]
        public void ShowingAll()
        {
            this.testFixture.RunAssert(() => Assert.Equal("true", this.testFixture.Page.AttributeValue));
        }
    }
}