using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter movie name.")]
        public string Name { get; set; }


        public GenreDto Genre { get; set; }
        [Required(ErrorMessage = "Please enter genre.")]
        public byte GenreId { get; set; }

        
        //[Required(ErrorMessage = "Please enter date added.")]
        public DateTime DateAdded { get; set; }

        
        [Required(ErrorMessage = "Please enter release date.")]
        public DateTime ReleaseDate { get; set; }

        
        [Required(ErrorMessage = "Please enter number in stock.")]
        [Range(1, 20, ErrorMessage = "Stock should be between 1 and 20")]
        public byte NumberInStock { get; set; }
    }
}