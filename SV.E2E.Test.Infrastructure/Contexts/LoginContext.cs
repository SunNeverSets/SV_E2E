using SV.E2E.Test.Infrastructure.DataModels.UI;
using SV.E2E.Test.Infrastructure.Pages;

namespace SV.E2E.Test.Infrastructure.Contexts
{
    public class LoginContext
    {
        private readonly LoginPage _loginPage;

        public LoginContext()
        {
            _loginPage = new LoginPage();
        }

        public void LogIn(User user)
        {
            _loginPage.UserNameTextField.SendKeys(user.UserName);
            _loginPage.PasswordTextField.SendKeys(user.Password);
            _loginPage.LoginButton.Click();
        }

        public string GetValidationErrorMessage()
        {
            return _loginPage.ValidationMessageLabel.Text;
        }
    }
}
