using SV.E2E.Test.Infrastructure.Driver;
using TechTalk.SpecFlow;

namespace SV.E2E.Tests
{
    [Binding]
    public class Hooks
    {
        [AfterScenario]
        public void CloseBrowser()
        {
            if (!IsAPIScenario())
                DriverService.Driver.Close();
        }

        [BeforeScenario]
        public void StartDriver()
        {
            if (!IsAPIScenario())
                DriverService.Driver = new Driver();
        }

        private bool IsAPIScenario()
        {
            return ScenarioContext.Current.ScenarioInfo.Tags.Contains("API_ONLY") || FeatureContext.Current.FeatureInfo.Tags.Contains("API_ONLY");
        }
    }
}
