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
        protected virtual Func<AppQuery, AppQuery> searchIcon { get; } = x => x.Class("ActionMenuItemView").Index(1);

        #endregion

        #region Methods

        public virtual bool IsAt()
        {
            return (IsElementExist(homeTitle) && IsElementExist(boxSets) && IsElementExist(collections));
        }

        public virtual void GoToProfile()
        {
            WaitForHomeScreen();
            Tap(profileIcon);
        }

        public virtual List<BurgerMenu> GetMenuItems()
        {
            var burgerMenu = new BurgerMenu();
            var actualBurgerMenuItems = AppManager.App.Query(x => x.Class("TiTableView").Class("ListView").Child().Child().Child());

            var actualBurgerMenuItemsList = new List<BurgerMenu>();
            foreach (var actualBurgerMenuItem in actualBurgerMenuItems)
            {
                    burgerMenu.MenuItem = actualBurgerMenuItem.Text;
                    actualBurgerMenuItemsList.Add(burgerMenu);
                    burgerMenu = new BurgerMenu();
            }

            return actualBurgerMenuItemsList;
        }

        #endregion
    }
}
