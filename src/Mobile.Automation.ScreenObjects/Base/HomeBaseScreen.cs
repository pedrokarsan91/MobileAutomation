using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class HomeBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> profileIcon { get; } = x => x.Class("ActionMenuItemView").Index(0);
        protected virtual Func<AppQuery, AppQuery> searchIcon { get; } = x => x.Class("ActionMenuItemView").Index(1);

        #endregion

        #region Methods

        public virtual void GoToProfile()
        {
            WaitForHomeScreen();
            Tap(profileIcon);
        }

        public virtual void TapSearch()
        {
            WaitForHomeScreen();
            Tap(searchIcon);
        }

        #endregion
    }
}
