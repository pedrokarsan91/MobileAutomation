using Mobile.Automation.ScreenObjects.Screens;

namespace Mobile.Automation.ScreenObjects
{
    public class Screen
    {
        private static T GetScreen<T>() where T : new()
        {
            var screen = new T();
            return screen;
        }

        public static OnboardingScreen OnboardingScreen
        {
            get { return GetScreen<OnboardingScreen>(); }
        }
    }
}
