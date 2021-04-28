using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Models
{
    public class Interest_Reg
    {
        public int PropertyID { get; set; }
        [MaxLength(60)]
        [EmailAddress]
        public string AccountEmail { get; set; }
        public virtual Property Property { get; set; }
        public virtual Account Account { get; set; }
    }
}
