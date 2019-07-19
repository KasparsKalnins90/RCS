namespace FirstWebApplication.Models
{
    using MovieApp.Logic.Database;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class UserModel
    {
        
        [StringLength(100)]
        [Display(Name = "Name")] // šeit var mainīt kā mēs gribam lai parāda šo nosaukumu tabulā
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [NotMapped]
        [Compare("Password", ErrorMessage ="Paroles nesakrīt!")]
        [StringLength(50)]
        public string Password2 { get; set; }


        [Key]
        public int Id { get; set; }
       public static UserModel FromData(User user)
        {
            return new UserModel()
            {
                Id = user.Id,
                Email = user.Email,
                Name = user.Name,
            };
        }
        
    }
}
