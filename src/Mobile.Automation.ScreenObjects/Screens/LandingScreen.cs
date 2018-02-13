using Mobile.Automation.ScreenObjects.Manager;
using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Screens
{
    public class LandingScreen
    {
        #region Elements

        Func<AppQuery, AppQuery> loginText = x => x.Text("Already have an account? Log in.");

        #endregion

        #region Methods

        public void IsAtLandingScreen()
        {
            AppManager.App.WaitForElement(loginText);
        }

        public void TapLogin()
        {
            AppManager.App.Tap(loginText);
        }

        #endregion
    }
}
