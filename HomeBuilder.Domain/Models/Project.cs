using System.Collections.Generic;

namespace HomeBuilder.Domain.Models
{
    public class Project
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        
        public ICollection<Activity> Activities { get; set; }


        public Project()
        {
            Activities = new List<Activity>();
        }
    }
}