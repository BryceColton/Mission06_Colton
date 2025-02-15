using System.ComponentModel.DataAnnotations;

namespace Mission06_Colton.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; } // Id to keep track of each record

        [Required]
        public string Title { get; set; } // Required

        [Required]
        public string Category { get; set; } // Required

        [Required]
        public string Director { get; set; } // Required

        [Required]
        public string Rating { get; set; } // Dropdown (G, PG, PG-13, R)

        [Required]
        public int Year { get; set; } // Enforce realistic movie years

        public bool Edited { get; set; } // Stored as 1 (true) and 0 (false) in DB

        public string? LentTo { get; set; } // Optional field

        [StringLength(25, ErrorMessage = "Must be 25 characters or less.")]
        public string? Notes { get; set; } // Optional with max 25 chars
    }
}
