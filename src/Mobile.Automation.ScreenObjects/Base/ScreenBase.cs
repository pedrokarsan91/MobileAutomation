using Mobile.Automation.ScreenObjects.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
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

        public void SwipeLeft(int numberOfTimes)
        {
            var startNumber = 0;
            while (startNumber < numberOfTimes)
            {
                AppManager.App.SwipeRightToLeft();
                startNumber++;
            }
        }

        public void Tap(Func<AppQuery, AppQuery> element)
        {
            AppManager.App.WaitForElement(element);
            AppManager.App.Tap(element);
        }

        public void ScrollDown()
        {
            AppManager.App.ScrollDown(strategy: ScrollStrategy.Gesture);
        }
    }
}
