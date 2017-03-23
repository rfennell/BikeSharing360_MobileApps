using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Xamarin.UITest.Android;

namespace BikeSharing.Clients.UITests
{
    [TestFixture]
    public class Tests
    {
        AndroidApp app;

        [SetUp]
        public void BeforeEachTest()
        {
            // TODO: If the Android app being tested is included in the solution then open
            // the Unit Tests window, right click Test Apps, select Add App Project
            // and select the app projects that should be tested.
            app = ConfigureApp
                .Android
                // TODO: Update this path to point to your Android app and uncomment the
                // code if the app is not included in the solution.
                .ApkFile ("../../../BikeSharing.Clients.Droid/bin/Debug/com.bikesharing.app.apk")
                .StartApp();
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void ViewMyRides()
        {
            app.Screenshot("Login screen");
            app.Tap(x => x.Marked("username"));
            app.EnterText(x => x.Marked("username"), "jamesm");
            app.Tap(x => x.Marked("password"));
            app.EnterText(x => x.Marked("password"), "qjqjqjq");
            app.Tap(x => x.Marked("signin"));
            app.Screenshot("Home screen");
            app.Tap(x => x.Marked("OK"));
            app.Tap(x => x.Text("My Rides"));
            app.Screenshot("My rides");

        }
    }
}

