using System.ComponentModel.DataAnnotations;

namespace Mission06_Koelliker.Models
{
    public class Movies
    {

        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [Range(1900, 2100, ErrorMessage = "Please enter a valid year")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Director is required")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        public string Rating { get; set; }

        [Required(ErrorMessage = "Edited is required")]
        public bool Edited { get; set; }

        [MaxLength(25, ErrorMessage = "Notes must be less than 25 characters")]
        public string Notes { get; set; }

    }
}
