using OpenQA.Selenium;
using DriverService = SV.E2E.Test.Infrastructure.Driver.DriverService;

namespace SV.E2E.Test.Infrastructure.Pages
{
    public class TrackingPage
    {
        private IWebDriver _driver => DriverService.Driver.GetWebDriver();

        public List<IWebElement> TrackingDataRows => _driver.FindElements(By.XPath("div.tracking-data-row")).ToList();
    }
}
