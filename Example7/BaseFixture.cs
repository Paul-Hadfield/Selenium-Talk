using System;
using Example7.Common;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;

namespace Example7
{
    public abstract class BaseFixture : IDisposable
    {
        protected readonly IWebDriver driver;

        protected BaseFixture()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .Build();

            this.driver = WebDriverFactory.Create(config);            
        }

        private bool TestFailed { get; set; }

        public void RunAssert(Action assert)
        {
            try
            {
                assert.Invoke();
            }
            catch (Exception)
            {
                this.ScreenShot();
                this.TestFailed = true;
                throw;
            }
        }

        public void Dispose()
        {
            if (!TestFailed)
            {
                driver?.Dispose();
            }
        }
        
        public void ScreenShot()
        {
            /*
            var screenshotDriver = this.driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            var bmpScreen = new Bitmap(new MemoryStream(screenshot.AsByteArray));

            // 2. Get screenshot of specific element
            IWebElement element = FindElement(by);
            var cropArea = new Rectangle(element.Location, element.Size);
            return bmpScreen.Clone(cropArea, bmpScreen.PixelFormat);
            */
        }
    }
}