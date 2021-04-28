using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Models
{
    public class Account
    {
        [Key]
        [MaxLength(60)]
        [EmailAddress]
        public string Email { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Number { get; set; }
        public List<Interest_Reg> Interest_Regs { get; set; }

    }
}
