using SV.E2E.Test.Infrastructure.Pages;

namespace SV.E2E.Test.Infrastructure.Contexts
{
    public class BaseContext
    {
        private BasePage _basePage;

        public BaseContext()
        {
            _basePage = new BasePage();
        }

        public void NavigateTo(string tab)
        {
            _basePage.PageTabElemets.Single(t => t.Text.Equals(tab)).Click();
        }

        public List<string> GetHeaderTabs()
        {
            return _basePage.PageTabElemets.Select(tab => tab.Text).ToList();
        }
    }
}