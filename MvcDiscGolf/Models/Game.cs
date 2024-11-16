using System;
using System.Data.Entity;

namespace MvcDiscGolf.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string Course { get; set; }
        public DateTime OpeningDate { get; set; }
        public string Level { get; set; }
        public decimal Price { get; set; }
    }
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}