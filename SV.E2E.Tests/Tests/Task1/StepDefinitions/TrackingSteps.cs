using FluentAssertions;
using SV.E2E.Test.Infrastructure.Contexts;
using TechTalk.SpecFlow;

namespace SV.E2E.Tests.Tests.Task1.StepDefinitions
{
    [Binding]
    public class TrackingSteps
    {
        private readonly TrackingContext _trackingContext;

        public TrackingSteps()
        {
            _trackingContext = new TrackingContext();
        }

        [Then(@"user sees the list of products")]
        public void ThenUserSeesTheListOfProducts()
        {
            _trackingContext.IsPageLoaded().Should().BeTrue();
        }
    }
}
