using System.IO;
using Xamarin.UITest;

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
            _app = ConfigureApp
                .Android
                .ApkFile("C:/dev/Mobile.Automation/src/Mobile.Automation.Specs/bin/Debug/Binaries/Instagram_com.instagram.android.apk")
                .StartApp();

            return _app;
        }
    }
}
