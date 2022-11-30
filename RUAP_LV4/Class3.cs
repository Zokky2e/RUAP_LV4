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
    public class UntitledTestCase4
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
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheUntitledTestCaseTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("pero.marincic@etfos.hr");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("ferit345\n");
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();
            driver.FindElement(By.LinkText("Books")).Click();
            driver.FindElement(By.XPath("//div[3]/div/div[2]/div[3]/div[2]/input")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//li[@id='topcartlink']/a/span")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("CountryId")).Click();
            new SelectElement(driver.FindElement(By.Id("CountryId"))).SelectByText("Bahrain");
            driver.FindElement(By.Id("ZipPostalCode")).Click();
            driver.FindElement(By.Id("ZipPostalCode")).Clear();
            driver.FindElement(By.Id("ZipPostalCode")).SendKeys("2312115");
            driver.FindElement(By.Name("estimateshipping")).Click();
            driver.FindElement(By.Id("termsofservice")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("checkout")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.Id("PickUpInStore")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='shipping-buttons-container']/input")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='payment-method-buttons-container']/input")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@id='payment-info-buttons-container']/input")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@value='Confirm']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
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

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
