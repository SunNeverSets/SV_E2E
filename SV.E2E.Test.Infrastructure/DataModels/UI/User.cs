namespace SV.E2E.Test.Infrastructure.DataModels.UI
{
    public class User
    {
        public string UserName { get; }

        public string Password { get; }

        public User(string userNname, string password)
        {
            UserName = userNname;
            Password = password;
        }
    }
}
