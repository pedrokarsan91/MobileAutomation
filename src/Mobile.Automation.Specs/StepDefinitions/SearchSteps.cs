using Mobile.Automation.ScreenObjects;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class SearchSteps
    {
        [Given(@"I navigate to a ""(.*)"" episode")]
        public void GivenINavigateToAEpisode(string seriesName)
        {
            Screen.HomeScreen.TapSearch();
            Screen.SearchScreen.SearchAndGoToEpisode(seriesName);
        }
    }
}
