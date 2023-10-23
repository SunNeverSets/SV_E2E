using SV.E2E.Test.Infrastructure.DataModels.UI;

namespace SV.E2E.Test.Infrastructure.Helpers
{
    public static class UsersStorage
    {
        public static Dictionary<string, User> Users { get; } = new Dictionary<string, User>
        {
            ["genuine"] = new User("genuine.user@dummy.com", "12345"),
            ["non genuine"] = new User("non.genuine.user@dummy.com", "12345"),
        };
    }
}
