using Mobile.Automation.ScreenObjects.Manager;
using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class HomeBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> profileIcon { get; } = x => x.Class("ActionMenuItemView").Index(0);
        protected virtual Func<AppQuery, AppQuery> homeTitle { get; } = x => x.Text("HOME");
        protected virtual Func<AppQuery, AppQuery> boxSets { get; } = x => x.Text("BOX SETS");
        protected virtual Func<AppQuery, AppQuery> collections { get; } = x => x.Text("COLLECTIONS");

        #endregion

        #region Methods

        public virtual void GoToProfile()
        {
            WaitForHomeScreen();
            AppManager.App.WaitForElement(profileIcon);
            AppManager.App.Tap(profileIcon);
        }

        private void WaitForHomeScreen()
        {
            AppManager.App.WaitForElement(homeTitle);
            AppManager.App.WaitForElement(boxSets);
            AppManager.App.WaitForElement(collections);
        }

        #endregion
    }
}
