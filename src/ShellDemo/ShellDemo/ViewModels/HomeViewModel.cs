using System;
using System.Threading.Tasks;
using AsyncAwaitBestPractices;
using MvvmHelpers;
using ShellDemo.Cache;
using ShellDemo.Models;
using Xamarin.Forms;

namespace ShellDemo.ViewModels
{
    public class HomeViewModel
    {
        private readonly ICacheStore _cacheStore;

        public HomeViewModel()
        {
            _cacheStore = DependencyService.Resolve<ICacheStore>();
            Cards = new ObservableRangeCollection<HomeCard>();

            LoadData().SafeFireAndForget();
        }

        public ObservableRangeCollection<HomeCard> Cards { get; }

        public async Task LoadData()
        {
            var data = await _cacheStore.GetHomeCards();
            Cards.AddRange(data);
        }
    }
}
