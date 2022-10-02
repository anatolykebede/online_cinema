using online_cinema.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace online_cinema.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "አክቲቪስቱ",
                            Logo = "https://i.ytimg.com/vi/ON6K73pzKQg/maxresdefault.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "ልማልልሽ",
                            Logo = "https://i.ytimg.com/vi/XK_my27eTGM/maxresdefault.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "ባላደራው",
                            Logo = "https://i.ytimg.com/vi/5D3wr7Ny1Sk/maxresdefault.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "ቻንስ ነው",
                            Logo = "https://i.ytimg.com/vi/gYUqRGQGLvY/maxresdefault.jpg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "ቀስቴ Keste",
                            Logo = "https://vhx.imgix.net/sodere/assets/34bcde57-ee13-448a-993f-1ae7c7be0863-901b7577.jpg?auto=format%2Ccompress&fit=crop&h=720&q=75&w=1280",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Mekonen Leake",
                            Bio = "This is Mekonen Leake Ethiopia's first movie actor",
                            ProfilePictureURL = "https://i.ytimg.com/vi/Bs3RPCfdU8M/maxresdefault.jpg"

                        },
                        new Actor()
                        {
                            FullName = "Abebe Balcha",
                            Bio = "This is Abebe Balcha Ethioia's series movie actor",
                            ProfilePictureURL = "https://rebeccafisseha.files.wordpress.com/2014/08/safe_image-php.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Selam Tesfaye",
                            Bio = "Selam Tesfaye is ethiopian best female movie actor",
                            ProfilePictureURL = "https://i0.wp.com/mereja.com/album/wp-content/uploads/2020/10/1603086917gn8k4.jpg?fit=1080%2C911&ssl=1"
                        },
                        new Actor()
                        {
                            FullName = "Netsanet Workneh",
                            Bio = "Netsanet Workneh is ethiopian comedy movie actor",
                            ProfilePictureURL = "https://yageru.com/images/artists/a34.jpg"
                        },
                        new Actor()
                        {
                            FullName = "Marta Goytom",
                            Bio = "Marta Goytom is a female ethiopian movie actor",
                            ProfilePictureURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRStdTrLgSFHoa2s_mrSiy7jZCQdU6xougbMA&usqp=CAU"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Kidist Yilma",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "data:image/jpeg;base64,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"

                        },
                        new Producer()
                        {
                            FullName = "Beza Hailu",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://static.wixstatic.com/media/a93c36_1a5dd19d5f9c47ec8d329c53f7509b18~mv2.jpg/v1/fill/w_640,h_400,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/a93c36_1a5dd19d5f9c47ec8d329c53f7509b18~mv2.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Haile Gerima",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://aaregistry.org/wp-content/uploads/2014/02/haile-gerima.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Aida Ashenafi",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "data:image/jpeg;base64,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"
                        },
                        new Producer()
                        {
                            FullName = "Meaza Ashenafi",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Meaza_Ashenafi_in_2018.jpg/640px-Meaza_Ashenafi_in_2018.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "አክቲቪስቱ",
                            Description = "This is አክቲቪስቱ movie description",
                            Price = 39.50,
                            ImageURL = "https://i.ytimg.com/vi/ON6K73pzKQg/maxresdefault.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "ልማልልሽ",
                            Description = "This is ልማልልሽ Redemption description",
                            Price = 29.50,
                            ImageURL = "https://i.ytimg.com/vi/XK_my27eTGM/maxresdefault.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "ባላደራው",
                            Description = "This is ባላደራው movie description",
                            Price = 39.50,
                            ImageURL = "https://i.ytimg.com/vi/5D3wr7Ny1Sk/maxresdefault.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "ቻንስ ነው",
                            Description = "This is ቻንስ ነው movie description",
                            Price = 39.50,
                            ImageURL = "https://i.ytimg.com/vi/gYUqRGQGLvY/maxresdefault.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "ቀስቴ Keste",
                            Description = "This is ቀስቴ Keste description",
                            Price = 39.50,
                            ImageURL = "https://vhx.imgix.net/sodere/assets/34bcde57-ee13-448a-993f-1ae7c7be0863-901b7577.jpg?auto=format%2Ccompress&fit=crop&h=720&q=75&w=1280",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "ክላስ ሜት",
                            Description = "This is ክላስ ሜት movie description",
                            Price = 39.50,
                            ImageURL = "https://i.ytimg.com/vi/k22EWrE6ZJE/maxresdefault.jpg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}
