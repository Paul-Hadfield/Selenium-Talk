using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Example5
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create(IConfiguration config)
        {
            if (UseFireFox(config))
            {
                return new FirefoxDriver();
            }
            
            return new ChromeDriver();
        }

        private static bool UseFireFox(IConfiguration config)
        {
            return config != null && string.Compare(config["Browser"], "Firefox", StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}