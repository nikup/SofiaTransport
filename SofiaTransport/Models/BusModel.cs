using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaTransport.Models
{
    class BusModel
    {
        public string Number { get; set; }
        public string lid { get; set; }
        public IEnumerable<DirectionModel> Directions;
    }
}
