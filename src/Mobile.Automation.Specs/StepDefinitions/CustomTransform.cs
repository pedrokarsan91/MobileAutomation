using Mobile.Automation.ScreenObjects.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Mobile.Automation.Specs.StepDefinitions
{
    [Binding]
    public class CustomTransform
    {
        [StepArgumentTransformation]
        public Credentials CredentialsTransform(Table credentials)
        {
            return credentials.CreateInstance<Credentials>();
        }
    }
}
