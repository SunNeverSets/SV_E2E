using OpenQA.Selenium;
using DriverService = SV.E2E.Test.Infrastructure.Driver.DriverService;

namespace SV.E2E.Test.Infrastructure.Pages
{
    public class BasePage
    {
        private IWebDriver _driver => DriverService.Driver.GetWebDriver();

        public List<IWebElement> PageTabElemets => _driver.FindElements(By.CssSelector("span.oxd-topbar-body-nav-tab-item")).ToList();
    }
}
