using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class Image
    {
        public string Id { get; set; }
        public string EventCenterId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsFeatured { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
