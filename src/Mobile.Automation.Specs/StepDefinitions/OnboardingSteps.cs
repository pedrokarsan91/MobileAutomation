using Mobile.Automation.ScreenObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class OnboardingSteps
    {
        [Given(@"I am on the onboarding screen")]
        public void GivenIAmOnTheOnboardingScreen()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsAt());
        }

        [Then(@"I should see the skip option")]
        public void ThenIShouldSeeTheSkipOption()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSkipOptionExist(), "Timed out waiting for skip link.");
        }

        [Then(@"the Welcome title")]
        public void ThenTheWelcomeTitle()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsWelcomeExist(), "Timed out waiting for title.");
        }

        [Then(@"the see it first title")]
        public void ThenTheSeeItFirstTitle()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSeeItFirstExist(), "Timed out waiting for title");
        }

        [Then(@"the box sets title")]
        public void ThenTheBoxSetsTitle()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsBoxSetsExist(), "Timed out waiting for title.");
        }

        [Then(@"the sub text ""(.*)""")]
        public void ThenTheSubText(string subtitle)
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSubTextExist(subtitle), "Timed out waiting for subtext.");
        }

        [Then(@"the UKTV logo")]
        public void ThenTheUKTVLogo()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsUktvLogoExist(), "Timed out waiting for logo.");
        }

        [Then(@"the cupcake logo")]
        public void ThenTheCupcakeLogo()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsCupcakeLogoExist(), "Timed out waiting for logo.");
        }

        [Then(@"the star logo")]
        public void ThenTheStarLogo()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsStarLogoExist(), "Timed out waiting for logo.");
        }

        [Then(@"the register button")]
        public void ThenTheRegisterButton()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsRegisterButtonExist(), "Timed out waiting for register.");
        }

        [Then(@"the sign in with Facebook button")]
        public void ThenTheSignInWithFacebookButton()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSignInWithFacebookButtonExist(), "Timed out waiting for sign in with Facebook.");
        }

        [Then(@"the sign in link")]
        public void ThenTheSignInLink()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSignInLinkExist(), "Timed out waiting for sign in link.");
        }

        [Then(@"I should be on the home screen")]
        public void ThenIShouldBeOnTheHomeScreen()
        {
            Screen.HomeScreen.IsAt();
        }
    }
}
