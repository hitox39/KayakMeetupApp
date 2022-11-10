using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayakMeetUpService.Data.Models
{
    public class Boat
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int YearMade { get; set; }
    }
}
