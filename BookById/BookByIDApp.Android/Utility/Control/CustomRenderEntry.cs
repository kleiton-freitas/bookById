using System;
using Xamarin.Forms.Platform.Android;
using Android.Runtime;
using Android.Content;
using Xamarin.Forms;
using BookByIDApp.Droid.Utility.Control;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomRenderEntry))]
namespace BookByIDApp.Droid.Utility.Control
{
    public class CustomRenderEntry : EntryRenderer
    {
        public CustomRenderEntry(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.Background = null;
                Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
            }
        }
    }
}
