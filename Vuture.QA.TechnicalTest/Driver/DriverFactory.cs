using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Vuture.QA.TechnicalTest.Driver
{
    public static class DriverFactory
    {


        public static IWebDriver Driver;

        public static void InitBrowser()
        {
            var driver = new ChromeDriver();
            Driver = driver;
            //Driver.Manage().Window.Maximize();
        }

        public static void GoToUrl(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }



    }
}
