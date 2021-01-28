using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BookByIDApp.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void BtnLogin_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Schedules());
        }
    }
}
