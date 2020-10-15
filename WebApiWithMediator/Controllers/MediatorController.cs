using Microsoft.AspNetCore.Mvc;

namespace WebApiWithMediator.Controllers
{
    public class MediatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
