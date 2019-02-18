using Example7.Common;
using Xunit;

namespace Example7
{
    public class GoogleHome : IClassFixture<GoogleHomeFixture>
    {
        private readonly GoogleHomeFixture testFixture;

        public GoogleHome(GoogleHomeFixture testFixture)
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