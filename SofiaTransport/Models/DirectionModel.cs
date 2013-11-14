using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofiaTransport.Models
{
    class DirectionModel
    {
        public string Name { get; set; }
        public string rid { get; set; }
        public IEnumerable<StopModel> Stops;
    }
}
