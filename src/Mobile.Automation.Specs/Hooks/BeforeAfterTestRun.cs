using TechTalk.SpecFlow;
using Xamarin.UITest;

namespace Mobile.Automation.Specs.Hooks
{
    [Binding]
    public class BeforeAfterTestRun
    {
        [BeforeTestRun]
        public static void BeforeTestRun()
        {
            if (!TestEnvironment.Platform.Equals(TestPlatform.Local))
            {
                return;
            }
        }
    }
}
