using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class EventCenter
    {
        public string Id { get; set; }
        public string YearOfMan { get; set; }
        public string Color { get; set; }
        public string TypeEventCenter { get; set; }
        public double Price { get; set; }
        public string UnitOfPrice { get; set; }
        public bool Approved { get; set; }
        public string DealerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
