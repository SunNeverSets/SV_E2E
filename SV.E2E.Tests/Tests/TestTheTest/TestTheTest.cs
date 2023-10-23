using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SV.E2E.Tests.Tests.TestTheTest
{
    [TestFixture]
    public class TestTheTest : BaseTest
    {
        private IWebDriver _driver => DriverManager.Driver;

        [Test]
        public void Test_The_Test()
        {
            //Arrange
            string usernameValue = "john_smith@sorted.com";
            string passwordValue = "Pa55w0rd!\"";
            string expectedUrl = "https://qa.sorted.com/newtrack/loginSuccess";

            //Act
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://qa.sorted.com/newtrack");

            wait.Until(driver => driver.FindElement(By.Id("header")).Displayed);

            IWebElement user = _driver.FindElement(By.XPath("//form[@id='loginForm']/input[1]"));
            IWebElement password = _driver.FindElement(By.XPath("//form[@id='loginForm']/input[2]"));
            IWebElement login = _driver.FindElement(By.CssSelector("form button"));

            user.SendKeys(usernameValue);
            password.SendKeys(passwordValue);
            login.Click();

            string actualUrl = _driver.Url;

            //Assert
            Assert.Equals(actualUrl, expectedUrl);
        }
    }
}
