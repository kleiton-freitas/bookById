using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookByIDApp.Views
{
    public partial class Schedules : ContentPage
    {
        public Schedules()
        {
            InitializeComponent();
        }

        void TapGestureRecognizer_Tapped(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ScheduleDetail());
        }
    }
}
