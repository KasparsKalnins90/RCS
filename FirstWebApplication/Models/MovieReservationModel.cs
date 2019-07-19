using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApplication.Models
{
    public class MovieReservationModel
    {
        public MovieModel movie { get; set; }

        public List<MovieSessionModel> Sessions { get; set; }

        public MovieReservationModel()
        {
            Sessions = new List<MovieSessionModel>();
        }
    }
}