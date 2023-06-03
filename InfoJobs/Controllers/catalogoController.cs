  using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InfoJobs.Controllers
{
    public class catalogoController : Controller
    {
        private readonly infojobsContext _infojobsContext;
        public catalogoController(infojobsContext infojobsContext)
        {
            _infojobsContext = infojobsContext;
        }

        public IActionResult Index()
        {
            /*var listaCategoria = (from t in _infojobsContext.categoria select t).ToList();
            ViewData["listaCategoria"] = new SelectList(listaCategoria, "id_categoria", "nombre_categoria");

            var listaDepartamentos = (from t in _infojobsContext.ubicacion select t).ToList();
            ViewData["listaDepartamentos"] = new SelectList(listaDepartamentos, "id_ubicacion", "departamento");

            var listaContratos = (from t in _infojobsContext.contrato select t).ToList();
            ViewData["listaContratos"] = new SelectList(listaContratos, "id_contrato", "tipo_contrato");

            var listaSectores = (from t in _infojobsContext.sector select t).ToList();
            ViewData["listaSectores"] = new SelectList(listaSectores, "id_sector", "tipo_sector");

            var listaExperiencia = (from t in _infojobsContext.experiencia select t).ToList();
            ViewData["listaExperiencia"] = new SelectList(listaExperiencia, "id_experiencia", "cantidad");*/

            return View();
        }

        public IActionResult busqueda(string nombre, int? categoria, int? ubicacion, DateTime? fechaPublicacion)
        {
            // Lógica de búsqueda y filtrado
           /* var trabajos = _infojobsContext.trabajos.AsQueryable();

            if (!string.IsNullOrEmpty(""))
            {
                trabajos = trabajos.Where(t => t.nombre.Contains(""));
            }

            return View(trabajos.ToList());

            if (categoria.HasValue)
            {
                trabajos = trabajos.Where(t => t.id_categoria == categoria.Value);
            }

            if (ubicacion.HasValue)
            {
                trabajos = trabajos.Where(t => t.id_ubicacion == ubicacion.Value);
            }

            if (fechaPublicacion.HasValue)
            {
                trabajos = trabajos.Where(t => t.fecha_publicacion == fechaPublicacion.Value);
            }*/
            return View(/*trabajos.ToList()*/);




        }
    }
}
