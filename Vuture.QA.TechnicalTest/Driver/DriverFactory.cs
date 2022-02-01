using System;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Vuture.QA.TechnicalTest.Driver
{
    public static class DriverFactory
    {
        public static IWebDriver WebDriver;

        public static void InitBrowser()
        {
            if (WebDriver != null)
            {
                Console.WriteLine($"ERROR: Executing InitBrowser - WebDriver has already been initialised");
                return;
            }
            foreach (var process in Process.GetProcessesByName("chromedriver"))
            {
                process.Kill();
            }
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");
            WebDriver = new ChromeDriver(chromeOptions);
            TurnOnWait();
        }

        public static void GoToUrl(string url)
        {
            if (WebDriver == null)
            {
                Console.WriteLine($"ERROR: Executing GoToUrl - WebDriver is not initialised");
                return;
            }
            WebDriver.Navigate().GoToUrl(url);
        }

        private static void TurnOnWait()
        {
            if (WebDriver == null)
            {
                Console.WriteLine($"INFO: Executing TurnOnWait - WebDriver is not initialised");
                return;
            };
            WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public static void Quit()
        {
            if (WebDriver == null)
            {
                Console.WriteLine($"INFO: Executing Quit - WebDriver is not initialised");
                return;
            };
            WebDriver.Quit();
        }
    }
}
