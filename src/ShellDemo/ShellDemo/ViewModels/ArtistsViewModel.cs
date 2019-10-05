using System;
using System.Threading.Tasks;
using MvvmHelpers;
using ShellDemo.Cache;
using ShellDemo.Models;
using Xamarin.Forms;
using AsyncAwaitBestPractices;
using AsyncAwaitBestPractices.MVVM;

namespace ShellDemo.ViewModels
{
    public class ArtistsViewModel : BaseViewModel
    {
        private readonly ICacheStore _cacheStore;

        public ArtistsViewModel()
        {
            _cacheStore = DependencyService.Resolve<ICacheStore>();
            Artists = new ObservableRangeCollection<Artist>();
            ArtistTappedCommand = new AsyncCommand<Artist>(ArtistTappedAsync);

            LoadData().SafeFireAndForget();
        }

        public IAsyncCommand<Artist> ArtistTappedCommand { get; }

        public ObservableRangeCollection<Artist> Artists { get; }

        public async Task LoadData()
        {
            var data = await _cacheStore.GetArtistsAsync();
            Artists.AddRange(data);
        }

        public async Task ArtistTappedAsync(Artist artist)
        {
            await Shell.Current.GoToAsync($"artistdetails?id={artist.Id}");
        }
    }
}
