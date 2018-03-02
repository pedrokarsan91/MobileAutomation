using Mobile.Automation.ScreenObjects;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class SignOutSteps
    {
        [When(@"I sign out from home")]
        public void WhenISignOutFromHome()
        {
            Screen.HomeScreen.GoToProfile();
            Screen.ProfileScreen.SignOut();
        }

        [When(@"I sign out")]
        public void WhenISignOut()
        {
            Screen.ProfileScreen.SignOut();
        }
    }
}
