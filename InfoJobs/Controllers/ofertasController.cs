using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoJobs.Controllers
{
    public class ofertasController : Controller
    {
        private readonly infojobsContext _infojobsContext;
        public ofertasController(infojobsContext infojobsContext) {
            _infojobsContext = infojobsContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }            
}
 
