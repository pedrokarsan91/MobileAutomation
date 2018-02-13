using Mobile.Automation.ScreenObjects;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class CommonSteps
    {
        [When(@"I swipe left once")]
        public void WhenISwipeLeftOnce()
        {
            Screen.OnboardingScreen.SwipeLeft(1);
        }

        [When(@"I swipe left twice")]
        public void WhenISwipeLeftTwice()
        {
            Screen.OnboardingScreen.SwipeLeft(2);
        }
    }
}
