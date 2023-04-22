using DotNetCore5CRUD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5CRUD.ViewModels
{
    public class MovieFormViewModel
    {
        [Required, StringLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        [Range(1,10)]
        public double Rate { get; set; }
        [Required, StringLength(2500)]
        public string StoreLine { get; set; }
        [Display(Name = "Select poster...")]
        public byte[] Poster { get; set; }//image 
        [Display(Name ="Genre")]
        public byte GenreID { get; set; } 
        public int MovieID { get; set; } 
        public IEnumerable<Genre> Genres { get; set; }
    }
}
