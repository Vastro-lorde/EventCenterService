using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventCenterService.Domain.Entities
{
    public class Comment
    {
        public string Id { get; set; }
        public string EventCenterId { get; set; }
        public string CommentText { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
