using SV.E2E.Test.Infrastructure.Pages;

namespace SV.E2E.Test.Infrastructure.Contexts
{
    public class TrackingContext
    {
        private TrackingPage _trackingPage;

        public TrackingContext()
        {
            _trackingPage = new TrackingPage();
        }

        public bool IsPageLoaded()
        {
            return _trackingPage.TrackingDataRows.Any(r => r.Displayed);
        }
    }
}
