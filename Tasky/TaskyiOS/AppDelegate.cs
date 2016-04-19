using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
using SQLite.Net.Platform.XamarinIOS;

//using KinveyXamarin;
//using KinveyXamariniOS;

namespace Tasky 
{
	public class Application 
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "AppDelegate");
		}
	}

	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate 
	{
		// class-level declarations
		UIWindow window;
		UINavigationController navController;
		UITableViewController homeViewController;

		// class-level declarations
//		public Client kinveyClient { get; set; }

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			//***************************************************************
			// Initialize Kinvey
/*			kinveyClient = new Client.Builder ("kid_b1QhapOlbb", "921d816807e845e39e75e391d90829c9")
				.setLogger(delegate(string msg) { Console.WriteLine("KINVEY: "+msg);})
				.setFilePath(NSFileManager.DefaultManager.GetUrls (NSSearchPathDirectory.DocumentDirectory, NSSearchPathDomain.User) [0].ToString())
				.setOfflinePlatform(new SQLitePlatformIOS())
				.build();
*/			//***************************************************************

			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			// create our nav controller
			navController = new UINavigationController ();

			// create our Todo list screen
			homeViewController = new Screens.HomeScreen ();

			navController.NavigationBar.TintColor = UIColor.FromRGB (0x6F, 0xA2, 0x2E); // 6FA22E dark-green
			navController.NavigationBar.BarTintColor = UIColor.FromRGB (0xCF, 0xEF, 0xA7); // CFEFA7 light-green

			UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes() {
				TextColor = UIColor.FromRGB (0x6F, 0xA2, 0x2E), // 6FA22E dark-green
				TextShadowColor = UIColor.Clear
			}); 

			// push the view controller onto the nav controller and show the window
			navController.PushViewController(homeViewController, false);
			window.RootViewController = navController;
			window.MakeKeyAndVisible ();

			return true;
		}

		// ***********************
		// handler for OAuth callback
		public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation){
//			return kinveyClient.User ().OnOAuthCallbackRecieved (url);
			return true;
		}
		// ************************

	}
}