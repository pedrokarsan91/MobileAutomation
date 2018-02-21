using Mobile.Automation.ScreenObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class ParentalControlSteps
    {
        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string settingsMenu)
        {
            Screen.SettingsScreen.NavigateTo(settingsMenu);
        }

        [When(@"I configure a pin for ""(.*)"" rated content")]
        public void WhenIConfigureAPinForRatedContent(int age)
        {
            Screen.ParentalControlScreen.ConfigurePin(age);
        }

        [Then(@"I should see the message ""(.*)""")]
        public void ThenIShouldSeeTheMessage(string expectedMessage)
        {
            Assert.IsTrue(Screen.ParentalControlScreen.IsElementExist(expectedMessage));
        }
    }
}
