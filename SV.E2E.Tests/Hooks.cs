using SV.E2E.Test.Infrastructure.Driver;
using TechTalk.SpecFlow;

namespace SV.E2E.Tests
{
    [Binding]
    public class Hooks
    {
        [AfterScenario(Order = 999)]
        public void CloseBrowser()
        {
            DriverService.Driver.Close();
        }

        [BeforeScenario(Order = 1)]
        public void StartDriver()
        {
            DriverService.Driver = new Driver();
        }
    }
}
