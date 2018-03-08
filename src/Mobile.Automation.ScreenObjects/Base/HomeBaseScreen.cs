using Mobile.Automation.ScreenObjects.Manager;
using Mobile.Automation.ScreenObjects.Models;
using System;
using System.Collections.Generic;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class HomeBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> profileIcon { get; } = x => x.Class("ActionMenuItemView").Index(0);

        #endregion

        #region Methods

        public virtual bool IsAt()
        {
            return (IsElementExist(homeTitle) && IsElementExist(boxSets));
        }

        public virtual void GoToProfile()
        {
            WaitForHomeScreen();
            Tap(profileIcon);
        }

        public virtual List<BurgerMenu> GetMenuItems()
        {
            var burgerMenu = new BurgerMenu();
            var actualBurgerMenuItems = AppManager.App.Query(x => x.Class("TiTableView").Class("TiTableViewRowProxyItem").Child().Child());

            var actualBurgerMenuItemsList = new List<BurgerMenu>();
            foreach (var actualBurgerMenuItem in actualBurgerMenuItems)
            {
                if (actualBurgerMenuItem.Text != null)
                {
                    burgerMenu.MenuItem = actualBurgerMenuItem.Text;
                    actualBurgerMenuItemsList.Add(burgerMenu);
                    burgerMenu = new BurgerMenu();
                }
            }

            if (IsElementExist("SIGN IN"))
            {
                burgerMenu = new BurgerMenu();
                burgerMenu.MenuItem = "SIGN IN";
                actualBurgerMenuItemsList.Add(burgerMenu);
            }

            return actualBurgerMenuItemsList;
        }

        #endregion
    }
}
