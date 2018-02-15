using Mobile.Automation.ScreenObjects;
using Mobile.Automation.ScreenObjects.Models;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class RegisterSteps
    {
        [When(@"I register a new user with the following details")]
        public void WhenIRegisterANewUserWithTheFollowingDetails(RegisterDetails registerDetails)
        {
            Screen.OnboardingScreen.NavigateToRegister();
            Screen.RegisterScreen.RegisterNewUser(registerDetails);
        }
    }
}
