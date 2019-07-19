using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApplication.Models
{
    public class MovieSessionModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Laiks")]
        public string Time { get; set; }

        [StringLength(10)]
        [Display(Name = "Cena")]
        public string Price { get; set; }

        public int MovieId { get; set; }

        public MovieApp.Logic.Database.Session ToData()
        {
            return new MovieApp.Logic.Database.Session()
            {
                Id = Id,
                Time = Time,
                MovieId = MovieId,
                Price = Price,
            };
        }
        public static MovieSessionModel FromData(MovieApp.Logic.Database.Session data)
        {
            return new MovieSessionModel()
            {
                Id = data.Id,
                Time = data.Time,
                MovieId = data.MovieId,
                Price = data.Price,
            };
        }
    }
}