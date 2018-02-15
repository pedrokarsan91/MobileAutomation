using Mobile.Automation.ScreenObjects;
using NUnit.Framework;
using Xamarin.UITest;

namespace Mobile.Automation.Specs.Base
{
    [TestFixture(Platform.Android, Category = "Android")]
    [TestFixture(Platform.iOS, Category = "iOS")]
    public class FeatureBase
    {
        [SetUp]
        public void SetUp()
        {
            Current.Platform = _platform;
        }

        private readonly Platform _platform;

        public FeatureBase(Platform platform)
        {
            _platform = platform;
        }
    }
}