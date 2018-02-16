using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class OnboardingBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> skipLink { get; } = x => x.Text("Skip");

        protected virtual Func<AppQuery, AppQuery> welcomeTitle { get; } = x => x.Text("Welcome");
        protected virtual Func<AppQuery, AppQuery> seeItFirstTitle { get; } = x => x.Text("See it first");
        protected virtual Func<AppQuery, AppQuery> boxSetsTitle { get; } = x => x.Text("Box sets");

        protected virtual Func<AppQuery, AppQuery> uktvLogo { get; } = x => x.Text("»");
        protected virtual Func<AppQuery, AppQuery> cupcakeLogo { get; } = x => x.Text(";");
        protected virtual Func<AppQuery, AppQuery> starLogo { get; } = x => x.Text(":");

        protected virtual Func<AppQuery, AppQuery> registerButton { get; } = x => x.Text("REGISTER");
        protected virtual Func<AppQuery, AppQuery> signInWithFacebookButton { get; } = x => x.Text("Sign in with Facebook");
        protected virtual Func<AppQuery, AppQuery> signInLink { get; } = x => x.Text("Sign In");

        #endregion

        #region Methods

        public virtual bool IsAt()
        {
            return IsElementExist(welcomeTitle);
        }

        public virtual bool IsSkipOptionExist()
        {
            return IsElementExist(skipLink);
        }

        public virtual bool IsWelcomeExist()
        {
            return IsElementExist(welcomeTitle);
        }

        public virtual bool IsSeeItFirstExist()
        {
            return IsElementExist(seeItFirstTitle);
        }

        public virtual bool IsBoxSetsExist()
        {
            return IsElementExist(boxSetsTitle);
        }

        public virtual bool IsSubTextExist(string subText)
        {
            return IsElementExist(x => x.Text(subText));
        }

        public virtual bool IsUktvLogoExist()
        {
            return IsElementExist(uktvLogo);
        }

        public virtual bool IsCupcakeLogoExist()
        {
            return IsElementExist(cupcakeLogo);
        }

        public virtual bool IsStarLogoExist()
        {
            return IsElementExist(starLogo);
        }

        public virtual bool IsRegisterButtonExist()
        {
            return IsElementExist(registerButton);
        }

        public virtual bool IsSignInWithFacebookButtonExist()
        {
            return IsElementExist(signInWithFacebookButton);
        }

        public virtual bool IsSignInLinkExist()
        {
            return IsElementExist(signInLink);
        }

        public virtual void NavigateToRegister()
        {
            Tap(registerButton);
        }

        public virtual void NavigateToSignIn()
        {
            Tap(signInLink);
        }

        public virtual void SkipRegistration()
        {
            Tap(skipLink);
        }

        #endregion
    }
}
