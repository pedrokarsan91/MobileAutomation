using System;
using Mobile.Automation.ScreenObjects.Manager;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class GeoLocationBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> title { get; } = x => x.Text("OUTSIDE THE UK?");
        protected virtual Func<AppQuery, AppQuery> closeIcon { get; } = x => x.Text("R");

        #endregion

        #region Methods

        public virtual bool IsAt()
        {
            return IsElementExist(title);
        }

        public virtual void Close()
        {
            Tap(closeIcon);
        }

        #endregion
    }
}
