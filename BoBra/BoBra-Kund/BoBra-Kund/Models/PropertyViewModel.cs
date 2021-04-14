using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra_Kund.Models
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
    }
}
