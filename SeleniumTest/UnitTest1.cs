using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            System.SetPro("webdriver.chrome.driver", "path of driver");
            WebDriver driver = new ChromeDriver();
            driver.Url = "https://orioks.miet.ru/user/login";
            WebElement username = (WebElement)driver.FindElement(By.Id("loginform-login"));
            WebElement password = (WebElement)driver.FindElement(By.Id("loginform-password"));
            WebElement authorization = (WebElement)driver.FindElement(By.Id("loginbut"));
            username.SendKeys("8181033");
            password.SendKeys("mem123");
            authorization.Click();
            String actualUrl = "https://orioks.miet.ru/";
            String expectedUrl = driver.Url;
            Assert.AreEqual(expectedUrl, actualUrl);
        }
    }
}
    