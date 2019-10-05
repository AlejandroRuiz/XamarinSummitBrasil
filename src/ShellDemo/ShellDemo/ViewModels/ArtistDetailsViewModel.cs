using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using MvvmHelpers;
using ShellDemo.Cache;
using ShellDemo.Models;
using Xamarin.Forms;

namespace ShellDemo.ViewModels
{
    public class ArtistDetailsViewModel : BaseViewModel
    {
        private readonly ICacheStore _cacheStore;

        public ArtistDetailsViewModel(string id)
        {
            ArtistId = id;

            _cacheStore = DependencyService.Resolve<ICacheStore>();

            LoadData().SafeFireAndForget();
        }

        public string ArtistId { get; }

        public Artist Artist { get; private set; }

        public async Task LoadData()
        {
            Artist = await _cacheStore.GetArtistAsync(ArtistId);
            OnPropertyChanged(nameof(Artist));
        }
    }
}
