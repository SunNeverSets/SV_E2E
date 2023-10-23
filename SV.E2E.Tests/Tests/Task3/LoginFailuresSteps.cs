using FluentAssertions;
using SV.E2E.Test.Infrastructure.API.Endpoints;
using SV.E2E.Test.Infrastructure.DataModels;
using TechTalk.SpecFlow;

namespace SV.E2E.Tests.Tests.Task3
{
    [Binding]
    public class LoginFailuresSteps
    {
        private readonly ScenarioContext _scenarioContext;
        private readonly LoginFailureApiContext _loginFailureApiContext;

        public LoginFailuresSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _loginFailureApiContext = new LoginFailureApiContext();
        }

        [When(@"I call GET session/loginfailtotal with parameters:")]
        public void WhenICallGETSessionLoginfailtotalWithParameters(LoginFailParametersDto parameters)
        {
            var loginFailures = _loginFailureApiContext.GetLoginFailRecords(parameters);
            _scenarioContext.Add("LoginFailures", loginFailures);
        }

        [When(@"I call PUT session/resetloginfailtotal with parameters:")]
        public void WhenICallPUTSessionResetloginfailtotalWithParameters(ResetLoginFailParametersDto parameters)
        {
            _loginFailureApiContext.PutLoginFailRecord(parameters);
        }

        [Then(@"the following login failures data are returned:")]
        public void ThenTheFollowingLoginFailuresDataAreReturned(List<LoginFailureDto> expectedLoginFailures)
        {
            var actualLoginFailures = _scenarioContext.Get<List<LoginFailureDto>>("LoginFailures");
            actualLoginFailures.Should().BeEquivalentTo(expectedLoginFailures, cfg =>
                cfg.Excluding(opt => opt.Id));
        }
    }
}
