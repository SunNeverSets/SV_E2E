using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SV.E2E.Test.Infrastructure.Extensions;

namespace SV.E2E.Test.Infrastructure.Driver
{
    public class Driver
    {
        private IWebDriver _driver;

        public static bool IsCreated { get; private set; }

        public IWebDriver GetWebDriver()
        {
            if (!IsCreated)
            {
                Initialize();
            }
            return _driver;
        }

        public void Initialize()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("start-maximized");
            chromeOptions.AddArguments("disable-infobars");
            chromeOptions.AddUserProfilePreference("profile.default_content_setting_values.notifications", 2);
            _driver = new ChromeDriver(chromeOptions);
            
            _driver.SetImplicitWait(TimeSpan.FromSeconds(5));

            IsCreated = true;
        }

        public void Close()
        {
            _driver.Dispose();
            _driver = null;
            IsCreated = false;
        }
    }
}
