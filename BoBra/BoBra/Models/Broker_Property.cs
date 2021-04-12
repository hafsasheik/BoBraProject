using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoBra.Models
{
    public class Broker_Property
    {
        public int PropertyID { get; set; }
        public int BrokerID { get; set; }
        public Property Property { get; set; }
        public Broker Broker { get; set; }
    }
}
