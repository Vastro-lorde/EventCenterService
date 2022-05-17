using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class Transaction
    {
        public string EventId { get; set; }
        public string TransactionId { get; set; }
        public double Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionRef { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
