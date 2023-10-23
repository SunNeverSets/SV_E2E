using OpenQA.Selenium;

namespace SV.E2E.Test.Infrastructure.Extensions
{
    public static class WebElementExtensions
    {
        public static void SetText(this IWebElement element, string text)
        {
            if (text != null)
            {
                element.SendKeys(text);
            }
        }
    }
}
