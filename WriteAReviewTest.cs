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
    public class WriteAReviewTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
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
        public void TheWriteAReviewTest()
        {
            driver.Navigate().GoToUrl(baseURL + "chrome://newtab/");
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("josip@gmail.com");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("josip123");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();
            driver.FindElement(By.LinkText("Books")).Click();
            driver.FindElement(By.LinkText("Computing and Internet")).Click();
            driver.FindElement(By.LinkText("Add your review")).Click();
            driver.FindElement(By.Id("AddProductReview_Title")).Click();
            driver.FindElement(By.Id("AddProductReview_Title")).Clear();
            driver.FindElement(By.Id("AddProductReview_Title")).SendKeys("Great book");
            driver.FindElement(By.Id("AddProductReview_ReviewText")).Click();
            driver.FindElement(By.Id("AddProductReview_ReviewText")).Click();
            driver.FindElement(By.Id("AddProductReview_ReviewText")).Clear();
            driver.FindElement(By.Id("AddProductReview_ReviewText")).SendKeys("This is a great book!");
            driver.FindElement(By.Name("add-review")).Click();
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
