using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InfoJobs.Controllers
{
    public class empleoEspecificoController : Controller
    {
        private readonly infojobsContext _infojobsContext;
        public empleoEspecificoController(infojobsContext infojobsContext)
        {
            _infojobsContext = infojobsContext;
        }
        public IActionResult Index()
        {
            

            return View();
        }

        public IActionResult Valoracion(trabajos nuevaValoracion)
        {
            _infojobsContext.Add(nuevaValoracion);
            _infojobsContext.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult comentario(comentarios nuevoComentario)
        {
            _infojobsContext.Add(nuevoComentario);
            _infojobsContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
