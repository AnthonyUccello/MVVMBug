using System;
using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Platforms.Android.Views;

namespace MvvmCrossBugs.Droid
{
	[Activity(
		 MainLauncher = true
		 , Theme = "@style/Theme.Splash"
		 , NoHistory = true
		 , ScreenOrientation = ScreenOrientation.Portrait)]
	public class SplashScreen : MvxSplashScreenActivity
	{
		public SplashScreen()
			: base(Resource.Layout.SplashScreen)
		{
		}

		protected override void OnStop()
		{
			base.OnStop();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
		}

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
		}
	}
}
