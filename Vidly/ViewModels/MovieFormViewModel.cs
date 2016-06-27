using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;
namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
        //public Movie Movie { get; set; }

        public int? Id { get; set; }
        [Required(ErrorMessage = "Please enter movie name.")]
        public string Name { get; set; }


       
        [Display(Name = "Genre")]
        [Required(ErrorMessage = "Please enter genre.")]
        public byte? GenreId { get; set; }

        

        [Display(Name = "Release Date")]
        [Required(ErrorMessage = "Please enter release date.")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Please enter number in stock.")]
        [Range(1, 20, ErrorMessage = "Stock should be between 1 and 20")]
        public byte? NumberInStock { get; set; }

        public MovieFormViewModel() //new movie
        {
            Id = 0;
        }

        public MovieFormViewModel(Movie movie) //edit existing movie
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}