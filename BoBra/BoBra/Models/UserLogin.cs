using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Models
{
    public class UserLogin
    {
        [Key]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Enter your Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter your password")]
        public string Password { get; set; }
    }
}
