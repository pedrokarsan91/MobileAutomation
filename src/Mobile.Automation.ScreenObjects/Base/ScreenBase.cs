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
        protected virtual Func<AppQuery, AppQuery> searchIcon { get; } = x => x.Class("ActionMenuItemView").Index(1);

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
            WaitForElement(homeTitle);
            WaitForElement(boxSets);
        }

        public void SelectBurgerMenuOption(string option)
        {
            if (option == "SIGN IN")
            {
                Tap(option);
            }
            else if(option == "MY PROFILE")
            {
                Tap(option);
            }
            else
            {
                var burgerMenuItems = AppManager.App.Query(x => x.Class("TiTableView").Class("TiTableViewRowProxyItem").Child().Child());
                var burgerMenuItemsCount = burgerMenuItems.Count();

                for (int index = 0; index < burgerMenuItemsCount; index++)
                {
                    if (burgerMenuItems[index].Text == option)
                    {
                        Tap(x => x.Class("TiTableView").Class("TiTableViewRowProxyItem").Child().Child().Index(index));
                        break;
                    }
                }
            }
        }

        public void NavigateTo(string element)
        {
            Tap(element);
        }

        public void TapSearch()
        {
            WaitForElement(searchIcon);
            Tap(searchIcon);
        }

        #endregion
    }
}
