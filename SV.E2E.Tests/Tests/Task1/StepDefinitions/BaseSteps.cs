using FluentAssertions;
using SV.E2E.Test.Infrastructure.Contexts;
using SV.E2E.Test.Infrastructure.Driver;
using TechTalk.SpecFlow;

namespace SV.E2E.Tests.Tests.Task1.StepDefinitions
{
    [Binding]
    public class BaseSteps
    {
        private readonly BaseContext _baseContext;

        public BaseSteps()
        {
            _baseContext = new BaseContext();
        }

        [Then(@"user sees the header with the following tabs '([^']*)'")]
        public void ThenUserSeesTheHeaderWithTheFollowingTabs(List<string> expectedTabs)
        {
            var actualTabs = _baseContext.GetHeaderTabs();
            actualTabs.Should().BeEquivalentTo(expectedTabs);
        }

        [When(@"user navigates to '([^']*)' page")]
        public void WhenUserNavigatesToTrackingDataPage(string tabName)
        {
            _baseContext.NavigateTo(tabName);
        }

        [Then(@"user is navigated to '([^']*)'")]
        public void ThenUserIsNavigatedTo(string expectedUrl)
        {
            DriverService.Driver.GetWebDriver().Url.Should().EndWith(expectedUrl);
        }
    }
}
