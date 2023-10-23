using FluentAssertions;
using SV.E2E.Test.Infrastructure.Contexts;
using SV.E2E.Test.Infrastructure.Helpers;
using TechTalk.SpecFlow;

namespace SV.E2E.Tests.Tests.Task1.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginContext _loginContext => new LoginContext();

        [Given(@"'([^']*)' logged in to application")]
        public void GivenLoggedInToApplication(string userName)
        {
            var user = UsersStorage.Users[userName];
            _loginContext.LogIn(user);
        }

        [Then(@"user sees '([^']*)' validation error on Login page")]
        public void ThenUserSeesPleaseVerifyYourCredentials_ValidationErrorOnLoginPage(string validationMessage)
        {
            _loginContext.GetValidationErrorMessage().Should().Be(validationMessage);
        }
    }
}
