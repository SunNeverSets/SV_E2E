using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SV.E2E.Test.Infrastructure.Extensions
{
    public static class WebDriverExtensions
    {
        public static string GetTitle(this IWebDriver driver)
        {
            return driver.Title;
        }

        public static void SetImplicitWait(this IWebDriver driver, TimeSpan timeSpan)
        {
            driver.Manage().Timeouts().ImplicitWait = timeSpan;
        }

        public static void Navigate(this IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds = 1)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }
}