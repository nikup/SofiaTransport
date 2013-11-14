using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaTransport.Models
{
    class TypeModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public IEnumerable<BusModel> Buses {get; set;}
    }
}
