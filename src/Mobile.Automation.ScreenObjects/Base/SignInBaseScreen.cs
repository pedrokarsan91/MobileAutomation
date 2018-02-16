using Mobile.Automation.ScreenObjects.Manager;
using Mobile.Automation.ScreenObjects.Models;
using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class SignInBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> registerNowLink { get; } = x => x.Text("Register now");
        protected virtual Func<AppQuery, AppQuery> emailTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(0);
        protected virtual Func<AppQuery, AppQuery> passwordTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(1);
        protected virtual Func<AppQuery, AppQuery> signInButton { get; } = x => x.Text("SIGN IN").Index(1);

        #endregion

        #region Methods

        public virtual void NavigateToRegisterNow()
        {
            Tap(registerNowLink);
        }

        public virtual void SignIn(SignInDetails signInDetails)
        {
            EnterText(emailTextBox, signInDetails.Email);
            AppManager.App.DismissKeyboard();
            EnterText(passwordTextBox, signInDetails.Password);
            AppManager.App.DismissKeyboard();
            Tap(signInButton);
        }

        #endregion
    }
}
