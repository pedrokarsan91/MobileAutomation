using Mobile.Automation.ScreenObjects.Manager;
using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Screens
{
    public class FeedScreen
    {
        #region Elements

        Func<AppQuery, AppQuery> tabs = x => x.Id("tabs");

        #endregion

        #region Methods

        public void IsAt()
        {
            AppManager.App.WaitForElement(tabs);
        }

        #endregion
    }
}
