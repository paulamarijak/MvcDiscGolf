using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcDiscGolf.Models
{
    public class Game
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Course { get; set; }
        
        [Display(Name = "Opening Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime OpeningDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(30)]
        public string Level { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [StringLength(25)]
        public string Rating { get; set; }
    }
    public class GameDBContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
    }
}