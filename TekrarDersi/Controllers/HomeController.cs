using Microsoft.AspNetCore.Mvc;
using TekrarDersi.Entities;
using TekrarDersi.Models;

namespace TekrarDersi.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager _userManager;

        public HomeController(UserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userManager.CreateUser(user);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult DeleteUser(int id)
        {
            _userManager.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            User currentUser = _userManager.GetUserById(id);
            return View(currentUser);
        }
        [HttpPost]
        public IActionResult UpdateUser(User user)
        {
            _userManager.UpdateUser(user);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult AddUserOld()
        {
            User user = new();
            var users = _userManager.GetAllUsers();

            AddUserViewModel model = new AddUserViewModel();
            model.User = user;
            model.Users = users;
            return View(model);
            
        }
    }
}
