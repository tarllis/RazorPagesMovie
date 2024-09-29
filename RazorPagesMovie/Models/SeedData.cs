using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
        {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                    
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return; // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Titulo = "When Harry Met Sally",
                        Data = DateTime.Parse("1989-2-12"),
                        Genero = "Romantic Comedy",
                        Preço = 7.99M,
                        Rating = "G"
                    },
                         new Movie
                         {
                             Titulo = "Ghostbusters ",
                             Data = DateTime.Parse("1984-3-13"),
                             Genero = "Comedy",
                             Preço = 8.99M,
                             Rating = "G"
                         },

                new Movie
                {
                    Titulo = "Ghostbusters 2",
                    Data = DateTime.Parse("1986-2-23"),
                    Genero = "Comedy",
                    Preço = 9.99M,
                    Rating = "G"
                },

                new Movie
                {
                    Titulo = "Rio Bravo",
                    Data = DateTime.Parse("1959-4-15"),
                    Genero = "Western",
                    Preço = 3.99M,
                    Rating = "G"

                }
                    );
                context.SaveChanges();
            }
       }
    }
}
