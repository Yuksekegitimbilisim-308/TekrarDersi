using TekrarDersi.Entities;

namespace TekrarDersi.Models
{
    public class AddUserViewModel
    {
        public IList<User> Users{ get; set; }
        public User User { get; set; }
    }
}
