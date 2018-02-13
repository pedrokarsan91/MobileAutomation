using Mobile.Automation.ScreenObjects.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class ScreenBase
    {
        public bool IsElementExist(Func<AppQuery, AppQuery> element)
        {
            try
            {
                AppManager.App.WaitForElement(element);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
