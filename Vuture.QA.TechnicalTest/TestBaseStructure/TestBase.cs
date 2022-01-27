using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;
using TechTalk.SpecFlow;
using Vuture.QA.TechnicalTest.Driver;

namespace Vuture.QA.TechnicalTest.TestBaseStructure
{
    [Binding]
    public class TestBase
    {
       

        [BeforeFeature]
        public static void StartOfTest()
        {
            try
            {
                
                DriverFactory.InitBrowser();
                DriverFactory.GoToUrl("https://demo.vuturevx.com/mvc/login/");
                Thread.Sleep(3000);
      

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        [AfterFeature]
        public static void EndOfTest()
        {
   
            DriverFactory.Driver.Quit();
        }



    }
}
