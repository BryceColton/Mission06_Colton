using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Colton.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; } // Primary key

        [Required]
        [ForeignKey("Category")]
        public int CategoryId { get; set; } // Foreign key (if applicable)
        public Category? Category { get; set; }

        [Required]
        [StringLength(100)] // Limit title length
        public string Title { get; set; }

        [Required]
        [Range(1888, 2100, ErrorMessage = "Year must be between 1888 and the current year.")]
        public int Year { get; set; } // Restrict to valid years

        [Required]
        [StringLength(50)] // Limit name length
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; } // String

        public bool Edited { get; set; } // Changed to bool for clarity

        public string? LentTo { get; set; } // Optional field

        public bool CopiedToPlex { get; set; } // Changed to bool for clarity

        [StringLength(100, ErrorMessage = "Notes cannot exceed 100 characters.")]
        public string? Notes { get; set; } // Optional, limited to 25 chars
    }
}
