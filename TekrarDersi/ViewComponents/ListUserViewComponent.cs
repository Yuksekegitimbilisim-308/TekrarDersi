using Microsoft.AspNetCore.Mvc;
using TekrarDersi.Entities;

namespace TekrarDersi.ViewComponents
{
    public class ListUserViewComponent : ViewComponent
    {
        private readonly UserManager _userManager;

        public ListUserViewComponent(UserManager userManager)
        {
            _userManager = userManager;
        }

        public IViewComponentResult Invoke()
        {
            IList<User> users= _userManager.GetAllUsers();
            return View(users);
        }
    }
}
