using Microsoft.AspNetCore.Mvc;

namespace InfoJobs.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
