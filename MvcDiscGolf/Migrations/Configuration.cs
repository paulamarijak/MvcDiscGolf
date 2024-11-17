namespace MvcDiscGolf.Migrations
{
    using MvcDiscGolf.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcDiscGolf.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcDiscGolf.Models.GameDBContext context)
        {
            context.Games.AddOrUpdate(i => i.Course,
                new Game
                {
                    Course = "Flower Field",
                    OpeningDate = DateTime.Parse("2024-3-1"),
                    Level = "Easy",
                    Rating = "Water hazard",
                    Price = 2.99M
                },

                 new Game
                 {
                     Course = "Pond Terrain",
                     OpeningDate = DateTime.Parse("2024-5-1"),
                     Level = "Medium",
                     Rating = "Water hazard",
                     Price = 4.99M
                 },

                 new Game
                 {
                     Course = "Sand Hills",
                     OpeningDate = DateTime.Parse("2024-3-1"),
                     Level = "Medium",
                     Rating = "Falling hazard",
                     Price = 2.99M
                 },

               new Game
               {
                   Course = "Pine Cone Forest",
                   OpeningDate = DateTime.Parse("2024-4-1"),
                   Level = "Hard",
                   Rating = "Trees hazard",
                   Price = 3.99M
               }
           );

        }
    }
}
