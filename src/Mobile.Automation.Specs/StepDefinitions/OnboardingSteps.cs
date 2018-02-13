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
            Assert.IsTrue(Screen.OnboardingScreen.IsSkipOptionExist());
        }

        [Then(@"I should see the Welcome title")]
        public void ThenIShouldSeeTheWelcomeTitle()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsWelcomeExist());
        }

        [Then(@"I should see the sub text ""(.*)""")]
        public void ThenIShouldSeeTheSubText(string subtitle)
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSubTextExist(subtitle));
        }

        [Then(@"the UKTV logo")]
        public void ThenTheUKTVLogo()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsUktvLogoExist());
        }

        [Then(@"the register button")]
        public void ThenTheRegisterButton()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsRegisterButtonExist());
        }

        [Then(@"the sign in with Facebook button")]
        public void ThenTheSignInWithFacebookButton()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSignInWithFacebookButtonExist());
        }

        [Then(@"the sign in link")]
        public void ThenTheSignInLink()
        {
            Assert.IsTrue(Screen.OnboardingScreen.IsSignInLinkExist());
        }

    }
}
