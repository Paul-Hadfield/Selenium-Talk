using Example7.Common;
using Xunit;

namespace Example7
{
    public class GoogleHomeTests : IClassFixture<GoogleHomeFixture>
    {
        private readonly GoogleHomeFixture testFixture;

        public GoogleHomeTests(GoogleHomeFixture testFixture)
        {
            this.testFixture = ReturnParameter.OrThrowIfNull(testFixture, nameof(testFixture));
        }
        
        [Fact]
        public void CorrectTitle()
        {
            this.testFixture.RunAssert(() => Assert.Equal("Google", this.testFixture.Page.Title));
        }
    }
}