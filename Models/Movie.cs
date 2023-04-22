using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCore5CRUD.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        [Required,MaxLength(250)]
        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }
        [Required,MaxLength(2500)]
        public string StoreLine { get; set; }
        [Required]
        public byte[] Poster { get; set; }//image
        public byte GenreID { get; set; }
        public  Genre Genre { get; set; }

    }
}
