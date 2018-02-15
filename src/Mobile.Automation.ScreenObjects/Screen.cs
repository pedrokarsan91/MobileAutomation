using Mobile.Automation.ScreenObjects.Base;
using Mobile.Automation.ScreenObjects.Screens.Onboarding;
using Mobile.Automation.ScreenObjects.Screens.Register;
using Xamarin.UITest;

namespace Mobile.Automation.ScreenObjects
{
    public class Screen
    {
        private static T GetScreen<T>() where T : new()
        {
            var screen = new T();
            return screen;
        }

        public static OnboardingBaseScreen OnboardingScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidOnboardingScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSOnboardingScreen>();
                }
            }
        }

        public static RegisterBaseScreen RegisterScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidRegisterScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSRegisterScreen>();
                }
            }
        }

        public static HomeBaseScreen HomeScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidHomeScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSHomeScreen>();
                }
            }
        }

        public static ProfileBaseScreen ProfileScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidProfileScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSProfileScreen>();
                }
            }
        }
    }
}
