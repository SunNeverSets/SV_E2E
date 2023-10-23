using SV.E2E.Test.Infrastructure.DataModels;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SV.E2E.Tests
{
    [Binding]
    public class StepsTransformations
    {
        [StepArgumentTransformation]
        public LoginFailParametersDto ToLoginFailParameters(Table table)
            => table.CreateInstance<LoginFailParametersDto>();

        [StepArgumentTransformation]
        public List<LoginFailureDto> ToLoginFailures(Table table)
            => table.CreateSet<LoginFailureDto>().ToList();

        [StepArgumentTransformation]
        public ResetLoginFailParametersDto ToResetLoginFailParameters(Table table)
            => table.CreateInstance<ResetLoginFailParametersDto>();

        [StepArgumentTransformation]
        public List<string> ToListOfString(string str)
            => str.Split(",").ToList();
    }
}
