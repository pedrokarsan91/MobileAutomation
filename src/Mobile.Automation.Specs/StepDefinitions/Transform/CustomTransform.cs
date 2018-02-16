using Mobile.Automation.ScreenObjects.Models;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MobBox.BddTests.Specs.StepDefs.Transform
{
    [Binding]
    public class CustomTransform
    {
        [StepArgumentTransformation]
        public RegisterDetails RegisterTransform(Table registerDetails)
        {
            return registerDetails.CreateInstance<RegisterDetails>();
        }

        [StepArgumentTransformation]
        public SignInDetails SignInTransform(Table signInDetails)
        {
            return signInDetails.CreateInstance<SignInDetails>();
        }
    }
}