using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium_21_IF4101_Transactional
{
    public class Tests
    {
        //Browser dirver
        IWebDriver webDriver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            webDriver.Navigate().GoToUrl("https://localhost:44372");
            IWebElement lknNews = webDriver.FindElement(By.LinkText("Sign In"));

            lknNews.Click();
        }

        //[TearDown]
        //public void TearDown() => webDriver.Quit();
    }
}