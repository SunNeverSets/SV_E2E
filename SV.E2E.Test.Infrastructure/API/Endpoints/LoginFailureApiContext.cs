using RestSharp;
using SV.E2E.Test.Infrastructure.DataModels;

namespace SV.E2E.Test.Infrastructure.API.Endpoints
{
    public class LoginFailureApiContext
    {
        private IRestClient _restClient;
        string BaseUrl = "https://localhost:7160/";

        public LoginFailureApiContext()
        {
            _restClient = new RestClient(BaseUrl);
        }

        public List<LoginFailureDto> GetLoginFailRecords(LoginFailParametersDto parameters)
        {
            string url = $"api/loginfailtotal";

            var request = new RestRequest(url, Method.Get);
            request.AddQueryParameter("userName", parameters.UserName);
            request.AddQueryParameter("failCount", parameters.FailCount);
            request.AddQueryParameter("fetchLimit", parameters.FetchLimit);

            return _restClient.ExecuteAsync(request).Result.Content.DerializeObject<List<LoginFailureDto>>();
        }

        public string PutLoginFailRecord(ResetLoginFailParametersDto parameters)
        {
            string url = $"api/resetloginfailtotal";

            var request = new RestRequest(url, Method.Put);
            request.AddQueryParameter("userName", parameters.UserName);

            return _restClient.ExecuteAsync(request).Result.Content;
        }
    }
}
