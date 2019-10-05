using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using ShellDemo.Cache;
using ShellDemo.Models;
using Xamarin.Forms;

namespace ShellDemo.Service
{
    public class ArtistsSearchHandler : SearchHandler
    {
        private readonly ICacheStore _cacheStore;

        public IEnumerable<Artist> Artists { get; private set; }

        public ArtistsSearchHandler()
        {
            _cacheStore = DependencyService.Resolve<ICacheStore>();
            LoadData().SafeFireAndForget();
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            if (string.IsNullOrWhiteSpace(newValue))
            {
                ItemsSource = Artists.OrderBy(item => item.Name);
            }
            else
            {
                ItemsSource = Artists.Where(item => item.Name.ToLower().Contains(newValue.ToLower())).OrderBy(item => item.Name).ToList<Artist>();
            }
        }

        protected override void OnItemSelected(object item)
        {
            ArtistTappedAsync((Artist)item).SafeFireAndForget();
        }

        public async Task LoadData()
        {
            var data = await _cacheStore.GetArtistsAsync();
            Artists = data;
        }

        public async Task ArtistTappedAsync(Artist artist)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Task.Delay(500);
            }
            await Shell.Current.GoToAsync($"artistdetails?id={artist.Id}");
        }
    }
}
