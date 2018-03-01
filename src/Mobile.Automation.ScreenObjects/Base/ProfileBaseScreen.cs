using System;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class ProfileBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> personalDetails { get; } = x => x.Text("PERSONAL DETAILS");

        #endregion

        #region Methods

        public virtual void IsAt()
        {
            WaitForElement(personalDetails);
        }

        #endregion
    }
}
