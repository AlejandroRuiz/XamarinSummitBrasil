using System;
using System.Collections.Generic;
using ShellDemo.Pages;
using Xamarin.Forms;

namespace ShellDemo
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        public async void OnNavigating(object sender, ShellNavigatingEventArgs args)
        {
            //if (ArtistDetailsPage.IsPresented)
            //{
            //    args.Cancel();
            //    await Current.DisplayAlert("YOUR APP", "Save your changes before leave", "OK");
            //}
        }
    }
}
