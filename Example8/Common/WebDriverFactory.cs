using System;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Example8.Common
{
    public static class WebDriverFactory
    {
        public static IWebDriver Create(IConfiguration config)
        {
            Throw.IfNull(config, nameof(config));
            
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