using Mobile.Automation.ScreenObjects.Base;
using Mobile.Automation.ScreenObjects.Manager;
using System;
using System.Linq;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Screens
{
    public class OnboardingScreen : ScreenBase
    {
        #region Elements

        Func<AppQuery, AppQuery> skipLink = x => x.Text("Skip");
        Func<AppQuery, AppQuery> welcome = x => x.Text("Welcome");
        Func<AppQuery, AppQuery> uktvLogo = x => x.Text("»");
        Func<AppQuery, AppQuery> registerButton = x => x.Text("REGISTER");
        Func<AppQuery, AppQuery> signInWithFacebookButton = x => x.Text("Sign in with Facebook");
        Func<AppQuery, AppQuery> signInLink = x => x.Text("Sign In");

        #endregion

        #region Methods

        public bool IsAt()
        {
            if (AppManager.App.Query(x => x.Text("Welcome")).Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSkipOptionExist()
        {
            return IsElementExist(skipLink);
        }

        public bool IsWelcomeExist()
        {
            return IsElementExist(welcome);
        }

        public bool IsSubTextExist(string subText)
        {
            Func<AppQuery, AppQuery> text = x => x.Text(subText);
            return IsElementExist(text);
        }

        public bool IsUktvLogoExist()
        {
            return IsElementExist(uktvLogo);
        }

        public bool IsRegisterButtonExist()
        {
            return IsElementExist(registerButton);
        }

        public bool IsSignInWithFacebookButtonExist()
        {
            return IsElementExist(signInWithFacebookButton);
        }

        public bool IsSignInLinkExist()
        {
            return IsElementExist(signInLink);
        }

        #endregion
    }
}
