namespace FirstWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Movie")]
    public partial class MovieModel
    {
        public MovieModel()
        {
            
        }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        public int Year { get; set; }

        public int CinemaId { get; set; }
        [Key]
        public int Id { get; set; }
        public CinemaModel Cinema { get; set; }

      

        public List<MovieSessionModel> MovieSessions { get; set; }
        public MovieApp.Logic.Database.Movie ToData()
        {
            return new MovieApp.Logic.Database.Movie()
            {
                Id = Id,
                Title = Title,
                CinemaId = CinemaId,
                Year = Year,
            };
        }
        public static MovieModel FromData(MovieApp.Logic.Database.Movie data)
        {
            return new MovieModel()
            {
                Id = data.Id,
                CinemaId = data.CinemaId,
                Title = data.Title,
                Year = data.Year,
            };
        }
    }
}
