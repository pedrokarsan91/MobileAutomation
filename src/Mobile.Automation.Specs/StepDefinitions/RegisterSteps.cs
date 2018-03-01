using Mobile.Automation.ScreenObjects;
using Mobile.Automation.ScreenObjects.Models;
using NUnit.Framework;
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

        [When(@"I register an invalid user with the following details")]
        public void WhenIRegisterAnInvalidUserWithTheFollowingDetails(RegisterDetails registerDetails)
        {
            Screen.RegisterScreen.RegisterInvalidUser(registerDetails);
        }

        [Given(@"I navigate to register now")]
        public void GivenINavigateToRegisterNow()
        {
            Screen.SignInScreen.NavigateToRegisterNow();
        }

        [Given(@"I navigate to register from episode")]
        public void GivenINavigateToRegisterFromEpisode()
        {
            Screen.EpisodeScreen.NavigateToRegister();
        }

        [When(@"I register")]
        public void WhenIRegister()
        {
            Screen.RegisterScreen.ScrollDownToRegisterButton();
        }

        [Then(@"I should see the register error ""(.*)""")]
        public void ThenIShouldSeeTheRegisterError(string expectedMessage)
        {
            Assert.IsTrue(Screen.RegisterScreen.IsElementExist(expectedMessage));
        }

    }
}
