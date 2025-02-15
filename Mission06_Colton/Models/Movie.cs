
using System.ComponentModel.DataAnnotations;

namespace Mission06_Colton.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]  
        public string Director { get; set; }
        [Required]
        public string Rating {  get; set; }
        [Required]
        public int Year { get; set; }
        public bool Edited { get; set; } //should be displayed as 1 and 0 in DB
        public string LentTo { get; set; } // Option
        public string Notes { get; set; }

    }
}
