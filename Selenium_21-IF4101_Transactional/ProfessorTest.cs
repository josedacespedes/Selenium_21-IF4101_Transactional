using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_21_IF4101_Transactional
{
    class ProfessorTest
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
        public void Professor()
        {
            HomePage homePage = new HomePage(webDriver);
            homePage.ClickLogin();

            LoginTest loginPage = new LoginTest(webDriver);
            Thread.Sleep(1000);
            loginPage.Login("admin@ucr.ac.cr","Admin12.");
            
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("firstNameProfessor")).SendKeys("Teresa");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("lastNameProfessor")).SendKeys("Mata Solano");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("idProfessor")).SendKeys("P-10290");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("emailProfessor")).SendKeys("TERESITA@ucr.ac.cr");
            Thread.Sleep(1000);
            webDriver.FindElement(By.Id("passwordProfessor")).SendKeys("Teresa-1");
            Thread.Sleep(1000);
            webDriver.FindElement(By.XPath("//*[@id='registerProfessorForm']/button")).Click();
            Thread.Sleep(1000);

        }

        //[TearDown]
        //public void TearDown() => webDriver.Quit();
    
}
}
