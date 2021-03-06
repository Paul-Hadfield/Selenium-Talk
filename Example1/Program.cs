﻿using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Chrome;

namespace Example1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://www.google.com/");

                var query = driver.FindElement(By.Name("q"));

                // Enter something to search for
                query.SendKeys("Cheese");

                // Now submit the form. WebDriver will find the form for us from the element
                query.Submit();

                // Google's search is rendered dynamically with JavaScript.
                // Wait for the page to load, timeout after 10 seconds
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(d => d.Title.StartsWith("cheese", StringComparison.OrdinalIgnoreCase));
            }
        }
    }
}