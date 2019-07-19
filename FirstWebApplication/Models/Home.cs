using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApplication.Models
{
    public partial class Home
    {
        public List<CinemaModel> Cinemas { get; set; }
        public List<MovieModel> Movies { get; set; }

    }
}   