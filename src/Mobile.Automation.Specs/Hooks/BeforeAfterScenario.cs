using Mobile.Automation.ScreenObjects;
using Mobile.Automation.ScreenObjects.Manager;
using TechTalk.SpecFlow;

namespace Mobile.Automation.Specs.Hooks
{
    [Binding]
    public class BeforeAfterScenario
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            AppManager.StartApp();
            if (Screen.GeoLocationScreen.IsAt())
            {
                Screen.GeoLocationScreen.Close();
            }
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}
