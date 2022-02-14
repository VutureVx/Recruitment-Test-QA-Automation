using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using Vuture.QA.TechnicalTest.Driver;
using Vuture.QA.TechnicalTest.TestBaseStructure;

namespace Vuture.QA.TechnicalTest.PageObjectModels
{
    public class EmailCampaignObjectModel
    {
        public EmailCampaignObjectModel()
        {
            PageFactory.InitElements(DriverFactory.Driver, this);
        }

    }
}
