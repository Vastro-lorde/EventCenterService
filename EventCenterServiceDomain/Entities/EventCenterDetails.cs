using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class EventCenterDetails
    {
        public string EventCenterId { get; set; }
        public string TypeOfSeat { get; set; }
        public bool AirCondition { get; set; }
        public bool CCTV { get; set; }
        public bool EventManager { get; set; }
        public bool Store { get; set; }
        public bool ParkingSpace { get; set; }
        public bool ColdRoom { get; set; }
        public bool Ushers { get; set; }
        public bool Decorator { get; set; }
        public string Capacity { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
