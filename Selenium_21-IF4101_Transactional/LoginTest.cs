using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_21_IF4101_Transactional
{
    class LoginTest
    {

        public LoginTest(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }

        IWebElement txtUserName => Driver.FindElement(By.Id("emailLogin"));
        IWebElement txtUserPassword => Driver.FindElement(By.Id("passwordLogin"));
        IWebElement btnLogin => Driver.FindElement(By.Id("form-submit"));

        public void Login(string userName, string password)
        {
            txtUserName.SendKeys(userName);
            txtUserPassword.SendKeys(password);
            btnLogin.Submit();
        }
    }
}

