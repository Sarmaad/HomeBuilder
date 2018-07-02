using System.Text;

namespace HomeBuilder.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
    }

    public class Contractor : User
    {

    }
}
