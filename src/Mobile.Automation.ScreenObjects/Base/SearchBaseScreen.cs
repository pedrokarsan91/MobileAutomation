using System;
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
            EnterText(searchTextBox, seriesName);
            var resultToSelect = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(seriesName.ToLower());
            Tap(resultToSelect);
        }

        #endregion
    }
}
