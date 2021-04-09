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
        public int AccountID { get; set; }
        public Property Property { get; set; }
        public Account Account { get; set; }
    }
}
