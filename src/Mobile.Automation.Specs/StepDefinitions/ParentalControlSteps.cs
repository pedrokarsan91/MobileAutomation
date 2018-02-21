using Mobile.Automation.ScreenObjects;
using NUnit.Framework;
using System;
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

        [Given(@"I configure a pin for ""(.*)"" rated content")]
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

        [When(@"I play a ""(.*)"" rated content")]
        public void WhenIPlayARatedContent(int age)
        {
            Screen.ParentalControlScreen.CloseSuccessPopUp();
            Screen.ParentalControlScreen.Close();
            Screen.SettingsScreen.TapSearch();

            switch (age)
            {
                case 15:
                    Screen.SearchScreen.SearchAndGoToEpisode("taskmaster");
                    break;
                case 18:
                    Screen.SearchScreen.SearchAndGoToEpisode("more sex please, we're british");
                    break;
                default:
                    throw new Exception("Unknown age");
            }

            Screen.EpisodeScreen.PlayVideo();
        }

        [Then(@"I should see the pin overlay")]
        public void ThenIShouldSeeThePinOverlay()
        {
            Assert.IsTrue(Screen.EpisodeScreen.IsPinOverlayExist());
        }
    }
}
