using Mobile.Automation.ScreenObjects.Manager;
using System;
using System.Linq;
using System.Threading;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class ScreenBase
    {
        #region Common Elements

        protected virtual Func<AppQuery, AppQuery> burgerMenuOpen { get; } = c => c.Marked("Open");
        protected virtual Func<AppQuery, AppQuery> homeTitle { get; } = x => x.Text("HOME");
        protected virtual Func<AppQuery, AppQuery> boxSets { get; } = x => x.Text("BOX SETS");
        protected virtual Func<AppQuery, AppQuery> collections { get; } = x => x.Text("COLLECTIONS");

        #endregion

        #region Common Methods

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

        public bool IsElementExist(string element)
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

        public void Tap(string element)
        {
            AppManager.App.WaitForElement(element);
            AppManager.App.Tap(element);
        }

        public void EnterText(Func<AppQuery, AppQuery> element, string text)
        {
            AppManager.App.WaitForElement(element);
            AppManager.App.EnterText(element, text);
        }

        public void ScrollDown()
        {
            AppManager.App.ScrollDown(strategy: ScrollStrategy.Gesture);
        }

        public void ScrollDownTo(Func<AppQuery, AppQuery> element)
        {
            AppManager.App.ScrollDownTo(element);
        }

        public void WaitForElement(Func<AppQuery, AppQuery> element)
        {
            AppManager.App.WaitForElement(element);
        }

        public void Wait()
        {
            Thread.Sleep(3000);
        }

        public void DismissKeyboard()
        {
            AppManager.App.DismissKeyboard();
        }

        public void OpenBurgerMenu()
        {
            WaitForHomeScreen();
            Tap(burgerMenuOpen);
        }

        public void WaitForHomeScreen()
        {
            AppManager.App.WaitForElement(homeTitle);
            AppManager.App.WaitForElement(boxSets);
            AppManager.App.WaitForElement(collections);
        }

        public void SelectBurgerMenuOption(string option)
        {
            var burgerMenuItems = AppManager.App.Query(x => x.Class("ListView").Class("TiTableViewRowProxyItem").Class("TiCompositeLayout").Child());
            var burgerMenuItemsCount = burgerMenuItems.Count();

            for (int index = 0; index < burgerMenuItemsCount; index++)
            {
                if (burgerMenuItems[index].Text == option)
                {
                    Tap(x => x.Class("ListView").Class("TiTableViewRowProxyItem").Class("TiCompositeLayout").Child().Index(index));
                    break;
                }
            }
        }

        public void NavigateTo(string element)
        {
            Tap(element);
        }

        #endregion
    }
}
