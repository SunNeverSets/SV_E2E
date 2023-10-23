namespace SV.E2E.Test.Infrastructure.DataModels
{
    public record LoginFailParametersDto
    {
        public string? UserName { get; set; }

        public string? FailCount { get; set; }

        public string? FetchLimit { get; set; }
    }
}
