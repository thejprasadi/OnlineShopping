using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.DataAccess.Entity
{
   public class User
    {
        [Key]
        public Int64 Id { get; set; }
        [Required]
        public String Email { get; set; }
        [Required]
        public String FName { get; set; }
        [Required]
        public String LName { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String Password { get; set; }
    }
}
