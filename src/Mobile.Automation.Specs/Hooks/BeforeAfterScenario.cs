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
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }
    }
}
