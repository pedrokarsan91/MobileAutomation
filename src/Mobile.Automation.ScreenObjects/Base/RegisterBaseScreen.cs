using Mobile.Automation.ScreenObjects.Manager;
using Mobile.Automation.ScreenObjects.Models;
using System;
using System.Linq;
using Xamarin.UITest.Queries;

namespace Mobile.Automation.ScreenObjects.Base
{
    public abstract class RegisterBaseScreen : ScreenBase
    {
        #region Elements

        protected virtual Func<AppQuery, AppQuery> emailTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(0);
        protected virtual Func<AppQuery, AppQuery> passwordTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(1);
        protected virtual Func<AppQuery, AppQuery> firstNameTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(2);
        protected virtual Func<AppQuery, AppQuery> lastNameTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(3);
        protected virtual Func<AppQuery, AppQuery> genderDropBox { get; } = x => x.Text("Please select your gender");
        protected virtual Func<AppQuery, AppQuery> dateOfBirthDatePicker { get; } = x => x.Text("dd/mm/yyyy");
        protected virtual Func<AppQuery, AppQuery> confirmDateOfBirth { get; } = x => x.Text("Confirm");
        protected virtual Func<AppQuery, AppQuery> postCodeTextBox { get; } = x => x.Id("titanium_ui_edittext").Index(0);
        protected virtual Func<AppQuery, AppQuery> subscriptionCheckBox { get; } = x => x.Id("titanium_ui_checkbox");
        protected virtual Func<AppQuery, AppQuery> continueButton { get; } = x => x.Text("Continue");
        protected virtual Func<AppQuery, AppQuery> SignInLink { get; } = x => x.Id("decor_content_parent").Class("ContentFrameLayout").Class("TiCompositeLayout").Index(4).Child().Text("Sign In");

        #endregion

        #region Methods

        public virtual void RegisterNewUser(RegisterDetails registerDetails)
        {
            AppManager.App.EnterText(emailTextBox, MakeEmailUnique(registerDetails.Email));
            AppManager.App.DismissKeyboard();
            AppManager.App.EnterText(passwordTextBox, registerDetails.Password);
            AppManager.App.DismissKeyboard();
            AppManager.App.EnterText(firstNameTextBox, registerDetails.FirstName);
            AppManager.App.DismissKeyboard();
            AppManager.App.EnterText(lastNameTextBox, registerDetails.LastName);
            AppManager.App.DismissKeyboard();
            AppManager.App.ScrollDownTo(genderDropBox);
            AppManager.App.Tap(genderDropBox);
            AppManager.App.Tap(registerDetails.Gender);
            AppManager.App.Tap(dateOfBirthDatePicker);
            AppManager.App.Tap(confirmDateOfBirth);
            AppManager.App.EnterText(postCodeTextBox, registerDetails.PostCode);
            AppManager.App.DismissKeyboard();
            ScrollDown();
            TapRegister();
            Tap(continueButton);
        }

        public virtual void NavigateToSignIn()
        {
            Tap(SignInLink);
        }

        private string MakeEmailUnique(string emailToMakeUnique)
        {
            var splitEmail = emailToMakeUnique.Split('@');
            return splitEmail[0] + "+" + GenerateUniqueString() + "@" + splitEmail[1];
        }

        private string GenerateUniqueString()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmssf");  
        }

        private void TapRegister()
        {
            var registerQueryResult = AppManager.App.Query(x => x.Text("REGISTER"));
            var registerQueryResultCount = registerQueryResult.Count();

            for (int index = 0; index < registerQueryResultCount; index++)
            {
                if (registerQueryResult[index].Enabled == true && registerQueryResult[index].Label != null)
                {
                    AppManager.App.Tap(x => x.Text("REGISTER").Index(index));
                    break;
                }
            }
        }

        #endregion
    }
}
