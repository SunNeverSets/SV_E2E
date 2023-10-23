using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SV.E2E.Tests.Tests.TestTheTest
{
    public class BaseTest
    {
        private IWebDriver _driver;

        [SetUp]
        public void SetUp()
        {
            // I'd suggest install Driver Manager or download package with the Driver
            string strDriverPath = "path of driver";
            _driver = new ChromeDriver(strDriverPath);
            DriverManager.Driver = _driver;
        }

        [TearDown]
        public void Teardown()
        {
            _driver.Quit();
        }
    }

    public static class DriverManager
    {
        public static IWebDriver Driver { get; set; }
    }
}
