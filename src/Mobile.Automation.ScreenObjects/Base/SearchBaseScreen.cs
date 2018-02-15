using Mobile.Automation.ScreenObjects.Manager;
using System;
using System.Linq;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class SearchBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> searchTextBox { get; } = x => x.Id("titanium_ui_edittext");

        #endregion

        #region Methods

        public virtual void SearchAndGoToEpisode(string seriesName)
        {
            AppManager.App.EnterText(searchTextBox, seriesName);
            var resultToSelect = seriesName.First().ToString().ToUpper() + seriesName.Substring(1);
            AppManager.App.Tap(resultToSelect);
        }

        #endregion
    }
}
