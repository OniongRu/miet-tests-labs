using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumTestChrome
{
    public class Tests
    {
        private string ChromeDriverPath = @"D:\Program Files\ChromeDriver";
        
        [Test]
        public void EnterOrioksAcc()
        {
            WebDriver driver = new ChromeDriver(ChromeDriverPath);
            driver.Url = "https://orioks.miet.ru/user/login";
            WebElement username = (WebElement)driver.FindElement(By.Id("loginform-login"));
            WebElement password = (WebElement)driver.FindElement(By.Id("loginform-password"));
            WebElement authorization = (WebElement)driver.FindElement(By.Id("loginbut"));
            username.SendKeys("xxx");
            password.SendKeys("xxx");
            authorization.Click();
            Thread.Sleep(1000);
            //_ = driver.Manage().Timeouts().ImplicitWait;
            string expectedUrl = driver.Url;
            string actualUrl = "https://orioks.miet.ru/";
            driver.Quit();
            Assert.AreEqual(expectedUrl, actualUrl);
        }

        [Test]
        public void MietSearchContainSearchBar()
        {
            WebDriver driver = new ChromeDriver(ChromeDriverPath);
            driver.Url = "https://miet.ru/search/";
            WebElement searchBar = null;
            try
            {
                searchBar = (WebElement)driver.FindElement(By.ClassName("search-bar"));
            }
            catch (NoSuchElementException)
            {
                driver.Quit();
                Assert.Fail("No Search bare on page");
            }
            driver.Quit();
            Assert.IsTrue(true);
        }

        [Test]
        public void MietSearchResultsOnSearch()
        {
            WebDriver driver = new ChromeDriver(ChromeDriverPath);
            driver.Url = "https://miet.ru/search/";

            WebElement searchBar = (WebElement)driver.FindElement(By.ClassName("search-bar__input"));
            searchBar.SendKeys("мемы\n");
            Thread.Sleep(1000);
            //_ = driver.Manage().Timeouts().ImplicitWait;
            WebElement PeopleCount = (WebElement)driver.FindElement(By.LinkText("Люди"));
            Assert.AreEqual(PeopleCount.GetAttribute("data-count"), 0.ToString());

            searchBar = (WebElement)driver.FindElement(By.ClassName("search-bar__input"));
            searchBar.Clear();
            searchBar.SendKeys("Кожухов\n");
            Thread.Sleep(1000);
            //_ = driver.Manage().Timeouts().ImplicitWait;
            PeopleCount = (WebElement)driver.FindElement(By.LinkText("Люди"));
            string str = PeopleCount.GetAttribute("data-count");
            int people_count = Int32.Parse(str);
            Assert.AreNotEqual(0, people_count);

            PeopleCount.Click();
            var count = driver.FindElements(By.ClassName("people-list__item")).Count;

            Assert.AreNotEqual(0, count);
            driver.Quit();
            Assert.IsTrue(true);
            //Assert.AreEqual(username.ToString(), "memes");
        }
    }
}