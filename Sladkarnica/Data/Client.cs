using Microsoft.AspNetCore.Identity;

namespace Sladkarnica.Data
{
    public class Client:IdentityUser
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
      
        public string Address { get; set; }
        public DateTime DateModification { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
