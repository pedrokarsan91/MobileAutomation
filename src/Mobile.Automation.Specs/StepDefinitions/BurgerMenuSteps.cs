using Mobile.Automation.ScreenObjects;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class BurgerMenuSteps
    {
        [When(@"I open the burger menu")]
        public void WhenIOpenTheBurgerMenu()
        {
            Screen.HomeScreen.OpenBurgerMenu();
        }

        [Then(@"I should see the following menu items")]
        public void ThenIShouldSeeTheFollowingMenuItems(Table expectedResults)
        {
            expectedResults.CompareToSet(Screen.HomeScreen.GetMenuItems());
        }
    }
}
