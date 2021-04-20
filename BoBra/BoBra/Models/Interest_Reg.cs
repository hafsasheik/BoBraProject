using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Models
{
    public class Interest_Reg
    {
        [Key]
        public int InterestID { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public int number { get; set; }
    }
}
