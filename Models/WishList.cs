using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventify.Models
{
    public class WishList
    {
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public DateTime AddedTimestamp { get; set; }
    }
}