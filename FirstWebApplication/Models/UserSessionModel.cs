using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApplication.Models
{
    public class UserSessionModel
    {
        public UserModel User { get; set; }

        public List<MovieSessionModel> Basket { get; set; }
        public UserSessionModel()
        {
            Basket = new List<MovieSessionModel>();
        }
    }
}