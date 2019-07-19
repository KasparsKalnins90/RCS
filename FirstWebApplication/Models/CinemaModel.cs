namespace FirstWebApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cinema")]
    public partial class CinemaModel
    {
        public CinemaModel()
        {
            Movies = new List<MovieModel>();
        }
        [StringLength(50)]
        [Display(Name = "Name")] // šeit var mainīt kā mēs gribam lai parāda šo nosaukumu tabulā
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Key]
        public int Id { get; set; }
        public List<MovieModel> Movies { get; set; }

        public int MovieCount { get; set; }

        public MovieApp.Logic.Database.Cinema ToData()
        {
            return new MovieApp.Logic.Database.Cinema()
            {
                Id = Id,
                Name = Name,
                Address = Address,
            };
        }
        public static CinemaModel  FromData(MovieApp.Logic.Database.Cinema data)
        {
            return new CinemaModel()
            {
                Id = data.Id,
                Address = data.Address,
                Name = data.Name,
            };
        }
    }
}
