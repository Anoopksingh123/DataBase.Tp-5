using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataBase.Tp_5.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public Location Location { get; set; }

    }
}
