using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PersonalFinance
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            App.Current.UserAppTheme = (App.Current.UserAppTheme == OSAppTheme.Light)
                ? OSAppTheme.Dark
                : OSAppTheme.Light;
        }
    }
}
