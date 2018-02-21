using Mobile.Automation.ScreenObjects.Manager;
using System;
using System.Linq;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class ParentalControlBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> title { get; } = x => x.Text("Set up a Parental Control PIN for this device");
        protected virtual Func<AppQuery, AppQuery> checkBox18 { get; } = x => x.Id("titanium_ui_checkbox").Index(0);
        protected virtual Func<AppQuery, AppQuery> checkBox15 { get; } = x => x.Id("titanium_ui_checkbox").Index(1);
        protected virtual Func<AppQuery, AppQuery> pinEntry1 { get; } = x => x.Id("titanium_ui_edittext").Index(0);
        protected virtual Func<AppQuery, AppQuery> pinEntry2 { get; } = x => x.Id("titanium_ui_edittext").Index(1);
        protected virtual Func<AppQuery, AppQuery> pinEntry3 { get; } = x => x.Id("titanium_ui_edittext").Index(2);
        protected virtual Func<AppQuery, AppQuery> pinEntry4 { get; } = x => x.Id("titanium_ui_edittext").Index(3);
        protected virtual Func<AppQuery, AppQuery> emailTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(4);
        protected virtual Func<AppQuery, AppQuery> enablePinButton { get; } = x => x.Text("Enable PIN");
        protected virtual Func<AppQuery, AppQuery> popUpBoxClose { get; } = x => x.Text("Okay");

        #endregion

        #region Methods

        public virtual void ConfigurePin(int age)
        {
            WaitForElement(title);

            switch (age)
            {
                case 15:
                    Tap(checkBox15);
                    break;
                case 18:
                    Tap(checkBox18);
                    break;
                default:
                    throw new Exception("Age not found");
            }

            ScrollDownTo(pinEntry1);
            EnterText(pinEntry1, "0");
            EnterText(pinEntry2, "0");
            EnterText(pinEntry3, "0");
            EnterText(pinEntry4, "0");
            ScrollDownTo(emailTextBox);
            EnterText(emailTextBox, "ami.patel@testuktv.co.uk");
            DismissKeyboard();
            Wait();
            Tap(enablePinButton);
        }

        public virtual void CloseSuccessPopUp()
        {
            Tap(popUpBoxClose);
        }

        public virtual void Close()
        {
            var query = AppManager.App.Query(x => x.Id("action_bar").Class("TextView"));
            var queryCount = query.Count();

            for (int index = 0; index < queryCount; index++)
            {
                if (query[index].Text == "PIN")
                {
                    Tap(x => x.Id("action_bar").Index(index).Class("ActionMenuItemView").Class("ActionMenuItemView"));
                }
            }
        }

        #endregion
    }
}
