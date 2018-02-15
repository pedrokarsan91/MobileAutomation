using Mobile.Automation.ScreenObjects;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public sealed class SignInSteps
    {
        [Then(@"I should be successfully signed in")]
        public void ThenIShouldBeSuccessfullySignedIn()
        {
            Screen.HomeScreen.GoToProfile();
            Screen.ProfileScreen.IsAt();
        }
    }
}
