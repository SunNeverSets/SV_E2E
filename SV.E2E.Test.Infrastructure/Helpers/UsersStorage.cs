using SV.E2E.Test.Infrastructure.DataModels.UI;

namespace SV.E2E.Test.Infrastructure.Helpers
{
    public static class UsersStorage
    {
        public static Dictionary<string, User> Users { get; } = new Dictionary<string, User>
        {
            ["Default"] = new User("Admin", "admin123"),
            ["test.user@dummy.com"] = new User("test.user@dummy.com", "12345"),
            ["test.user.tab1@dummy.com"] = new User("test.user.tab1@dummy.com", "12345"),
            ["test.user.tab2@dummy.com"] = new User("test.user.tab2@dummy.com", "12345"),
        };
    }
}
