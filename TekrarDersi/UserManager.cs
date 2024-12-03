using TekrarDersi.Entities;

namespace TekrarDersi
{
    public class UserManager
    {
        private readonly AppDbContext _context;

        public UserManager(AppDbContext context)
        {
            _context = context;
        }
      
        public IList<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }
        public User? GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(x => x.Id == id);
        }
        public void CreateUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            User currentUser = GetUserById(user.Id);
            currentUser.Username = user.Username;
            currentUser.Password = user.Password;
            currentUser.SecretKey = user.SecretKey;
            _context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            User user =  GetUserById(id);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }


    }
}
