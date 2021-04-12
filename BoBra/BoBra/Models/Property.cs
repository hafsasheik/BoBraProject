using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Models
{
    public class Property
    {
        [Key]
        public int PropertyID { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string LivingArea { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public int BuildYear { get; set; }
        [Required]
        public string HouseType { get; set; }
        [Required]
        public string PlotArea { get; set; }
        [Required]
        public string BiArea { get; set; }
        public DateTime ViewingDate { get; set; }
        public List<Interest_Reg> Interest_Reg { get; set; }
        public List<Broker_Property> Broker_Property { get; set; }
    }
}

