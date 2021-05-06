using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Selenium_21_IF4101_Transactional
{
    public class HomePage
    {
       
        public HomePage(IWebDriver webDriver)
        {
            Driver = webDriver;
            
        }

        private IWebDriver Driver { get; }

        public IWebElement login => Driver.FindElement(By.Id("navbarDropdown2"));
        public void ClickLogin() => login.Click();


        IWebElement linkSignIn => Driver.FindElement(By.LinkText("Sign In"));

        public bool GoToSignIn() => linkSignIn.Displayed;
    }
}
