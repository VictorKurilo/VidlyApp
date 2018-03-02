﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VidlyApp.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int Id { get; set; }

        
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }
        
        [Required]
        public DateTime DateAdded { get; set; }

        [Required]
        public int Stock { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        public int GenreId { get; set; }
    }
}