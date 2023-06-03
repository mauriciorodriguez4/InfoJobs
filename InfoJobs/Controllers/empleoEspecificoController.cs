using Firebase.Auth;
using Firebase.Storage;
using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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

        public IActionResult detalles(int id_oferta)
        {
            var listadoDeOfer = (from o in _infojobsContext.oferta
                                 join e in
                                _infojobsContext.empresa on o.id_empresa equals e.id_empresa
                                 where o.id_oferta == id_oferta
                                 select new
                                 {
                                     id_empresa = o.id_empresa,
                                     nombre = e.nombre,
                                     descripcion = o.descripcion,
                                     logo = e.logo,
                                     id_oferta = o.id_oferta,
                                     titulo = o.titulo,
                                     ubicacion = o.ubicacion,
                                     requisitos = o.requisitos,
                                     contacto = o.contacto

                                 }).ToList<object>();
            ViewData["listadoDeOfer"] = listadoDeOfer;
            return View("Index", listadoDeOfer);
        }

        public void AgregarAplicante(aplicante nAplicante) 
        {
            _infojobsContext.Add(nAplicante);
            _infojobsContext.SaveChanges();
            
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
