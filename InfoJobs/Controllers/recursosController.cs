using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InfoJobs.Controllers
{
    public class recursosController : Controller
    {
        private readonly infojobsContext _infojobsContext;
        public recursosController(infojobsContext infojobsContext) {
            _infojobsContext = infojobsContext;
        }
        public IActionResult Index()
        {
            var listadoDeOfer = (from e in _infojobsContext.oferta

                                 select new
                                 {
                                     id_oferta = e.id_oferta,
                                     titulo = e.titulo,
                                     ubicacion = e.ubicacion,
                                     requisitos = e.requisitos,
                                     contacto = e.contacto

                                 }).ToList();
            ViewData["listadoDeOfer"] = listadoDeOfer;
            return View();
            
        }
    }            
}
 
