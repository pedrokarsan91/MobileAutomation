using Mobile.Automation.ScreenObjects;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class SignInSteps
    {
        [Given(@"I navigate to sign in")]
        public void GivenINavigateToSignIn()
        {
            Screen.OnboardingScreen.NavigateToSignIn();
        }

        [Then(@"I should be successfully signed in")]
        public void ThenIShouldBeSuccessfullySignedIn()
        {
            Screen.HomeScreen.GoToProfile();
            Screen.ProfileScreen.IsAt();
        }

        [Given(@"I navigate to sign in from home")]
        public void GivenINavigateToSignInFromHome()
        {
            Screen.HomeScreen.GoToProfile();
        }

        [Given(@"I navigate to ""(.*)"" from burger menu")]
        public void GivenINavigateToFromBurgerMenu(string burgerMenuItem)
        {
            Screen.HomeScreen.OpenBurgerMenu();
            Screen.HomeScreen.SelectBurgerMenuOption(burgerMenuItem);
        }
    }
}
