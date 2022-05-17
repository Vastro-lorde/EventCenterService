using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class Dealer
    {
        public string UserId { get; set; }
        public string CompanyName { get; set; }
        public string Type { get; set; }
        public string BusinessEmail { get; set; }
        public string BusinessPhoneNumber { get; set; }
        public string IdNumber { get; set; }
        public string SocialMedia { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
