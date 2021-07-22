using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_21_IF4101_Transactional
{
    class ApplicantTest
    {
        //Browser dirver
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44372");
            webDriver.Manage().Window.Maximize();
        }

        [Test]
        public void Applicant()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.GoToSignIn();

            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("firstNameApplicant")).SendKeys("Teresa");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("lastNameApplicant")).SendKeys("Mata Serrano");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("studentIdApplicant")).SendKeys("B88908");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("emailApplicant")).SendKeys("TERE.MATA@ucr.ac.cr");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("passwordApplicant")).SendKeys("Teresa-1");
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//*[@id='registerApplicantForm']/button")).Click();
            Thread.Sleep(1000);

        }

        //[TearDown]
        //public void TearDown() => webDriver.Quit();
    }
}
