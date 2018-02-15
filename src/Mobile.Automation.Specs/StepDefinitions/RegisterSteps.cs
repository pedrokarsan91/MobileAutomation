using Mobile.Automation.ScreenObjects;
using Mobile.Automation.ScreenObjects.Models;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class RegisterSteps
    {
        [Given(@"I navigate to register")]
        public void GivenINavigateToRegister()
        {
            Screen.OnboardingScreen.NavigateToRegister();
        }

        [When(@"I register a new user with the following details")]
        public void WhenIRegisterANewUserWithTheFollowingDetails(RegisterDetails registerDetails)
        {
            Screen.RegisterScreen.RegisterNewUser(registerDetails);
        }

        [Given(@"I navigate to register now")]
        public void GivenINavigateToRegisterNow()
        {
            Screen.SignInScreen.NavigateToRegisterNow();
        }
    }
}
