using System.Collections.Generic;

namespace HomeBuilder.Domain.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Contractor> Employees { get; set; }

        public Supplier()
        {
            Employees = new List<Contractor>();
        }
    }
}