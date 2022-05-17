using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class Offers
    {
        public string Id { get; set; }
        public string EventCenterId { get; set; }
        public string DescriptionText { get; set; }
        public double Discount { get; set; }
        public string TypeOfOffer { get; set; }
        public bool IsActive { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
