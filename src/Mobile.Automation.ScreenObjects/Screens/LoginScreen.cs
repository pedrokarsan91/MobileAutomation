using Mobile.Automation.ScreenObjects.Manager;
using Mobile.Automation.ScreenObjects.Models;
using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Screens
{
    public class LoginScreen
    {
        #region Elements

        Func<AppQuery, AppQuery> username = x => x.Id("login_username");
        Func<AppQuery, AppQuery> password = x => x.Id("password");
        Func<AppQuery, AppQuery> loginButton = x => x.Text("Log In");

        #endregion

        #region Methods

        public void Login(Credentials credentials)
        {
            AppManager.App.WaitForElement(username);
            AppManager.App.EnterText(username, credentials.Username);
            AppManager.App.DismissKeyboard();

            AppManager.App.WaitForElement(password);
            AppManager.App.EnterText(password, credentials.Password);
            AppManager.App.DismissKeyboard();

            AppManager.App.WaitForElement(loginButton);
            AppManager.App.Tap(loginButton);
        }

        #endregion
    }
}
