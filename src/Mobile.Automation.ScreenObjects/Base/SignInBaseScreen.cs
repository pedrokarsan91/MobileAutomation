using Mobile.Automation.ScreenObjects.Manager;
using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class SignInBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> registerNowLink { get; } = x => x.Text("Register now");

        #endregion

        #region Methods

        public virtual void NavigateToRegisterNow()
        {
            AppManager.App.Tap(registerNowLink);
        }

        #endregion
    }
}
