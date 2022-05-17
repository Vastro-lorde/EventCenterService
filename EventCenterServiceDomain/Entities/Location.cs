using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class Location
    {
        public string Id { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public string DealerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
