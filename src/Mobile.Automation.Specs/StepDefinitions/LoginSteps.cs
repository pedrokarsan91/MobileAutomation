using Mobile.Automation.ScreenObjects;
using Mobile.Automation.ScreenObjects.Models;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I am on the login screen")]
        public void GivenIAmOnTheLoginScreen()
        {
            Screen.LandingScreen.IsAtLandingScreen();
        }

        [When(@"I login with the following details")]
        public void WhenILoginWithTheFollowingDetails(Credentials credentials)
        {
            Screen.LandingScreen.TapLogin();
            Screen.LoginScreen.Login(credentials);
        }

        [Then(@"I should be successfully loged in")]
        public void ThenIShouldBeSuccessfullyLogedIn()
        {
            Screen.FeedScreen.IsAt();
        }

    }
}
