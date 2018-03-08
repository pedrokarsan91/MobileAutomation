using System;
using Xamarin.UITest;
using Xamarin.UITest.Configuration;

namespace Mobile.Automation.ScreenObjects.Manager
{
    public static class AppManager
    {
        private static IApp _app;

        public static IApp App
        {
            get { return _app ?? StartApp(); }
            set { _app = value; }
        }

        public static IApp StartApp()
        {
            switch (TestEnvironment.Platform)
            {
                case TestPlatform.Local:
                    {
                        if (Current.Platform == Platform.Android)
                        {
                            _app = ConfigureApp
                                .Android
                                .ApkFile("../../../Mobile.Automation.Specs/Binaries/uktv-test.apk")
                                .StartApp();
                        }
                        else if (Current.Platform == Platform.iOS)
                        {
                            _app = ConfigureApp
                                .iOS
                                .InstalledApp("com.uktv.play")
                                .StartApp(AppDataMode.Clear);
                        }
                    }
                    break;
                default:
                    {
                        throw new ArgumentException("Unsupported platform");
                    }
            }

            return _app;
        }
    }
}
