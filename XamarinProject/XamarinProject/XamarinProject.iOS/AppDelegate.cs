using Foundation;
using Prism;
using Prism.Ioc;
using System.Linq;
using UIKit;


namespace XamarinProject.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App(new iOSInitializer()));

            return base.FinishedLaunching(app, options);
        }

        public override UIInterfaceOrientationMask GetSupportedInterfaceOrientations(UIApplication application, UIWindow forWindow)
        {
            var mainPage = Xamarin.Forms.Application.Current.MainPage;
            if (mainPage.Navigation.NavigationStack.Last() is Views.MainPage)
            {
                return UIInterfaceOrientationMask.Landscape;
            }
            else if (mainPage.Navigation.NavigationStack.Last() is Views.MainPageWith5Players)
            {
                return UIInterfaceOrientationMask.Landscape;
            } else if (mainPage.Navigation.NavigationStack.Last() is Views.MainPageWith6Players)
            {
                return UIInterfaceOrientationMask.Landscape;
            }

            return UIInterfaceOrientationMask.Portrait;
        }


    }

    public class iOSInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register any platform specific implementations
        }
    }


}
