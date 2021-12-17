using library_web_api.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_web_api.Data
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
                    context.Books.AddRange(new Book()
                    {
                        Title = "The Bridge on the Drina",
                        Description = "The Bridge on the Drina is a historical novel by the Yugoslav writer Ivo Andric",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 5,
                        Genre = "Historical fiction",
                        Author = "Ivo Andric",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    },
                    new Book()
                    {
                        Title = "The Fortress",
                        Description= "A novel on 18th century Sarajevo under Ottoman rule, featuring a soldier returned from the wars.",                        
                        IsRead = false,
                        Genre = "Historical fiction",
                        Author = "Mesa Selimovic",
                        CoverUrl = "https...",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
