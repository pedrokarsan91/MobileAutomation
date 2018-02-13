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

        public static LandingScreen LandingScreen
        {
            get { return GetScreen<LandingScreen>(); }
        }

        public static LoginScreen LoginScreen
        {
            get { return GetScreen<LoginScreen>(); }
        }

        public static FeedScreen FeedScreen
        {
            get { return GetScreen<FeedScreen>(); }
        }
    }
}
