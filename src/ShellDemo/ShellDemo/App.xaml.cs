using System;
using ShellDemo.Cache;
using ShellDemo.Pages;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellDemo
{
    public partial class App : Application
    {

        public App()
        {
            RegisterTypes();
            RegisterPages();

            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void RegisterTypes()
        {
            DependencyService.Register<MockCacheStore>();
        }

        private void RegisterPages()
        {
            Routing.RegisterRoute("artistdetails", typeof(ArtistDetailsPage));
        }
    }
}
