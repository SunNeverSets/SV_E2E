using OpenQA.Selenium;
using DriverService = SV.E2E.Test.Infrastructure.Driver.DriverService;

namespace SV.E2E.Test.Infrastructure.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver => DriverService.Driver.GetWebDriver();

        public IWebElement UserNameTextField => _driver.FindElement(By.CssSelector("input[name=username]"));

        public IWebElement PasswordTextField => _driver.FindElement(By.CssSelector("input[name=password]"));

        public IWebElement LoginButton => _driver.FindElement(By.CssSelector("button[class*=login]"));

        public IWebElement ValidationMessageLabel => _driver.FindElement(By.CssSelector("label#error"));
    }
}
