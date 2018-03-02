using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class ProfileBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> personalDetails { get; } = x => x.Text("PERSONAL DETAILS");
        protected virtual Func<AppQuery, AppQuery> signOutButton { get; } = x => x.Text("SIGN OUT");

        #endregion

        #region Methods

        public virtual void IsAt()
        {
            WaitForElement(personalDetails);
        }

        public virtual void SignOut()
        {
            Tap(signOutButton);
        }

        #endregion
    }
}
