using System.ComponentModel.DataAnnotations;

namespace INFT3050.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        [Required(ErrorMessage = "Please eneter a name.")]
        public string Name { get; set; }

        [Range(1889, 2999, ErrorMessage = "Year must be after 1889.")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating.")]
        [Range(1, 5, ErrorMessage =
        "Rating must be between 1 and 5.")]
        public int? Rating { get; set; }

        [Required(ErrorMessage = "Please enter a genre.")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
