using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class EpisodeBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> playButton { get; } = x => x.Text("G");
        protected virtual Func<AppQuery, AppQuery> registerNowButton { get; } = x => x.Text("REGISTER NOW");
        protected virtual Func<AppQuery, AppQuery> signInButton { get; } = x => x.Text("SIGN IN");

        #endregion

        #region Methods

        public virtual void NavigateToRegister()
        {
            Tap(playButton);
            Tap(registerNowButton);
        }

        public virtual void NavigateSignIn()
        {
            Tap(playButton);
            Tap(signInButton);
        }

        #endregion
    }
}
