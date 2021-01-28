
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BookByIDApp.Droid
{
    [Activity
        (
        Label = "Reserve Pelo ID",
        Icon = "@mipmap/ic_launcher",
        MainLauncher = true ,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation |
        ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize,
        Theme = "@style/MainTheme.Splash"
        )]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // Create your application here
            OverridePendingTransition(0, 0);
        }
    }
}
