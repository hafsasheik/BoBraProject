using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra_Kund_MVC.Models
{
    public class PropertyViewModel
    {
        public int PropertyID { get; set; }
        public string Adress { get; set; }
        public string LivingArea { get; set; }
        public int Rooms { get; set; }
        public int BuildYear { get; set; }
        public string HouseType { get; set; }
        public string PlotArea { get; set; }
        public string BiArea { get; set; }
        public DateTime ViewingDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Fname { get; set; }

        [Required]
        public string Lname { get; set; }

        [Required]
        public int Number { get; set; }
    }
}
