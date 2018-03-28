using System;
using System.ComponentModel.DataAnnotations;
using VidlyApp.DbContext;

namespace VidlyApp.Models
{
    public class Movie
    {

        public int Id { get; set; }
      
        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        public Genre Genre { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        
        [Range(1, 20)]
        [Display(Name = "Number in Stock")]
        public int Stock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}