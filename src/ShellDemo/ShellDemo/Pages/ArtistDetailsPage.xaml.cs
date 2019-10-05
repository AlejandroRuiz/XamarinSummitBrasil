using System;
using System.Collections.Generic;
using ShellDemo.ViewModels;
using Xamarin.Forms;

namespace ShellDemo.Pages
{
    [QueryProperty(nameof(ArtistId), "id")]
    public partial class ArtistDetailsPage : ContentPage
    {
        private string _artistId;

        public ArtistDetailsPage()
        {
            InitializeComponent();
        }

        public string ArtistId
        {
            get => _artistId;
            set
            {
                _artistId = value;
                BindingContext = new ArtistDetailsViewModel(_artistId);
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            IsPresented = true;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            IsPresented = false;
        }

        public static bool IsPresented { get; set; }
    }
}
