using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShellDemo.Models;

namespace ShellDemo.Cache
{
    public interface ICacheStore
    {
        Task<IEnumerable<Artist>> GetArtistsAsync();

        Task<Artist> GetArtistAsync(string id);

        Task<IEnumerable<HomeCard>> GetHomeCards();
    }
}
