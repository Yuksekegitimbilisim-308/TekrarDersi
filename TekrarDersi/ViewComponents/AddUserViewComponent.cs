using Microsoft.AspNetCore.Mvc;

namespace TekrarDersi.ViewComponents
{
    public class AddUserViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
