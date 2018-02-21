using Mobile.Automation.ScreenObjects.Base;
using Mobile.Automation.ScreenObjects.Screens.Episode;
using Mobile.Automation.ScreenObjects.Screens.Onboarding;
using Mobile.Automation.ScreenObjects.Screens.ParenalControl;
using Mobile.Automation.ScreenObjects.Screens.Register;
using Mobile.Automation.ScreenObjects.Screens.Search;
using Mobile.Automation.ScreenObjects.Screens.Settings;
using Mobile.Automation.ScreenObjects.Screens.SignIn;
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

        public static SignInBaseScreen SignInScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidSignInScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSSignInScreen>();
                }
            }
        }

        public static SearchBaseScreen SearchScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidSearchScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSSearchScreen>();
                }
            }
        }

        public static EpisodeBaseScreen EpisodeScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidEpisodeScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSEpisodeScreen>();
                }
            }
        }

        public static SettingsBaseScreen SettingsScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidSettingsScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSSettingsScreen>();
                }
            }
        }

        public static ParentalControlBaseScreen ParentalControlScreen
        {
            get
            {
                if (Current.Platform == Platform.Android)
                {
                    return GetScreen<AndroidParentalControlScreen>();
                }
                else
                {
                    return GetScreen<AppleiOSParentalControlScreen>();
                }
            }
        }
    }
}
