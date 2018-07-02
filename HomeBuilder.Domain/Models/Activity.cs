using System;

namespace HomeBuilder.Domain.Models
{
    public class Activity
    {
        // Activity might need tags to aid in filtering and grouping
        public string Name { get; set; }
        public DateTime ProposedStartOn { get; set; }
        public DateTime? ConfirmedStartOn { get; set; }
        public DateTime? CompletedOn { get; set; }

        public bool IsStarted { get; set; }
        
        public Contractor Contractor { get; set; }
    }
}