using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShellDemo.Models;

namespace ShellDemo.Cache
{
    public class MockCacheStore : ICacheStore
    {
        private List<Artist> _artists = new List<Artist>
        {
            new Artist
            {
                Name = "Bad Bunny",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/812r+bAyUML.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            },
            new Artist
            {
                Name = "Snoop Dogg",
                ImageUrl = "http://www.hhgroups.com/imagenes/artistas/snoop-dogg-artista.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            },
            new Artist
            {
                Name = "Daddy Yankee",
                ImageUrl = "http://e-cdn-images.deezer.com/images/artist/5f45206580cde1388f71ccc7f8226768/500x500.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            },
            new Artist
            {
                Name = "Ariana Grande",
                ImageUrl = "https://content-images.p-cdn.com/images/d6/11/26/56/612a46ad8015bec36381deef/_500W_500H.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            },
            new Artist
            {
                Name = "Siddhartha",
                ImageUrl = "https://i.musicaimg.com/letras/500/2445589.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            },
            new Artist
            {
                Name = "Post Malone",
                ImageUrl = "https://i1.sndcdn.com/avatars-000404451534-thnhi5-t500x500.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            },
            new Artist
            {
                Name = "Billie Eilish",
                ImageUrl = "https://y.gtimg.cn/music/photo_new/T001R500x500M0000034MZS446AF7O.jpg",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In tortor velit, molestie quis erat rutrum, pellentesque vulputate ipsum. Vivamus aliquam nunc risus, vitae rutrum quam varius nec. Curabitur vitae diam at nunc fermentum luctus. Sed eu luctus sem, sed tincidunt dolor. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Suspendisse potenti. Quisque condimentum ut orci vel fringilla. In scelerisque mi tortor, id finibus sapien tempus ac. Nulla facilisi. Nullam nunc ipsum, maximus eget arcu at, aliquam ultrices sem. Nam in fermentum massa. Nunc sit amet fermentum augue.",
                Id = Guid.NewGuid().ToString()
            }
        };

        private List<HomeCard> _homeCards = new List<HomeCard>
        {
            new HomeCard
            {
                Title = "Top Albums",
                Subtitle = "OASIS",
                Description = "Album by Bad Bunny & J Balvin • 8 songs",
                ImageUrl = "https://www.radioactiva.cl/wp-content/uploads/2019/07/bad.jpg"
            },
            new HomeCard
            {
                Title = "Recommended new releases",
                Subtitle = "Portratit of The Dogg",
                Description = "Album by Snoop Dogg • 12 songs",
                ImageUrl = "https://direct.rhapsody.com/imageserver/images/alb.394056178/500x500.jpg"
            },
            new HomeCard
            {
                Title = "Playing Near You",
                Subtitle = "Alemán",
                Description = "Friday, 18 Oct",
                ImageUrl = "https://yt3.ggpht.com/a/AGF-l79MTIhLC8Y-EFKq2Kl7FaqihciB3geKMPnbNw=s288-c-k-c0xffffffff-no-rj-mo"
            }
        };

        public Task<Artist> GetArtistAsync(string id)
        {
            var artist = _artists.FirstOrDefault(item => item.Id == id);
            return Task.FromResult(artist);
        }

        public Task<IEnumerable<Artist>> GetArtistsAsync()
        {
            return Task.FromResult(_artists.AsEnumerable());
        }

        public Task<IEnumerable<HomeCard>> GetHomeCards()
        {
            return Task.FromResult(_homeCards.AsEnumerable());
        }
    }
}
