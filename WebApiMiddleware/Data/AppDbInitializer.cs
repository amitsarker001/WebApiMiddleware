using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiMiddleware.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                        new Model.Book()
                        {
                            Title = "1st book title",
                            Description = "1st book description",
                            IsRead = true,
                            DateRead = DateTime.Now.AddDays(-10),
                            Rate = 4,
                            Genre = "Biography",
                            Author = "First Author",
                            CoverUrl = "http..",
                            DateAdded = DateTime.Now
                        },
                        new Model.Book()
                        {
                            Title = "2nd book title",
                            Description = "2nd book description",
                            IsRead = false,
                            DateRead = DateTime.Now.AddDays(-5),
                            Rate = 4,
                            Genre = "Science",
                            Author = "Second Author",
                            CoverUrl = "https..",
                            DateAdded = DateTime.Now
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
