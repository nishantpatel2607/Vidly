using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter movie name.")]
        public string  Name { get; set; }

       
        public Genre Genre { get; set; }
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please enter genre.")]
        public byte GenreId { get; set; }

        [Display(Name = "Date Added")]
        //[Required(ErrorMessage = "Please enter date added.")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter release date.")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Please enter number in stock.")]
        [Range (1,20,ErrorMessage = "Stock should be between 1 and 20")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

    }
}