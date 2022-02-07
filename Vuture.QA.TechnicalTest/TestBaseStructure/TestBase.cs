using System;
using System.Threading;
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
            DriverFactory.InitBrowser();
        }

        [AfterFeature]
        public static void EndOfTest()
        {
            DriverFactory.Driver.Quit();
        }
    }
}
