using System;
using Microsoft.Extensions.Configuration;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
                .Build();
            
            using (var driver = WebDriverFactory.Create(config))
            {
                var page = GoogleSearchPage.Load(driver);
                page.Search("Cheese");
                
                Console.WriteLine(page.Title);
            }
        }
    }
}