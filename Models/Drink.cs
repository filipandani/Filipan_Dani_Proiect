using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filipan_Dani_Proiect.Models
{
    public class Drink
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Liters { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
