using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class NavigationTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://demowebshop.tricentis.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.That(verificationErrors.ToString(), Is.EqualTo(""));
        }
        
        [Test]
        public void TheNavigationTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Books")).Click();
            driver.FindElement(By.LinkText("Computers")).Click();
            driver.FindElement(By.LinkText("Electronics")).Click();
            driver.FindElement(By.LinkText("Apparel & Shoes")).Click();
            driver.FindElement(By.LinkText("Digital downloads")).Click();
            driver.FindElement(By.LinkText("Jewelry")).Click();
            driver.FindElement(By.LinkText("Gift Cards")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
