using System;
using System.ComponentModel.DataAnnotations;
using ValidationSample.Validation;

namespace ValidationSample.Models
{

    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [ClassicMovie(1960)]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required(ErrorMessage = "The {0} is required")]
        [StringLength(1000)]
        public string Description { get; set; }

        [Range(10, 999.99)]
        public decimal Price { get; set; }

        public Genre Genre { get; set; }

        public bool PreOrder { get; set; }
    }

}
