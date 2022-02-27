using Microsoft.EntityFrameworkCore;

namespace WebAppStart.Data.SeeData
{
    public class SeeData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebAppStartContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebAppStartContext>>()))
            {
                if (context.Movie.Any()) //Проверка на заполнение
                    return;

                context.Movie.AddRange( // Множественное добавление
                    new Models.Movie
                    {
                        Title = "Человек паук 3",
                        ReleaseDate = DateTime.Parse("2021-10-11"),
                        Genre = "Фэнтэзи,Фильм",
                        Price = 150M
                    },
                    new Models.Movie
                    {
                        Title = "Книга Бобы Фета",
                        ReleaseDate = DateTime.Parse("2022-1-15"),
                        Genre = "Фэнтэзи,Сериал",
                        Price = 200M
                    },
                    new Models.Movie
                    {
                        Title = "Кингсмэн 3",
                        ReleaseDate = DateTime.Parse("2021-11-13"),
                        Genre = "Комедия,Фильм",
                        Price = 190M
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
