using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;

namespace InfoJobs.Controllers
{
    public class recursosController : Controller
    {
        private readonly infojobsContext _infojobsContext;
        public recursosController(infojobsContext infojobsContext)
        {
            _infojobsContext = infojobsContext;
        }
        public IActionResult Index()
        {

            listas();
            return View();
        }
        public void listas(){
            var listadoDeOfer = (from o in _infojobsContext.oferta
                                 join e in
                                 _infojobsContext.empresa on o.id_empresa equals e.id_empresa
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

                                 }).ToList();
            ViewData["listadoDeOfer"] = listadoDeOfer;

            var listadoDeNoticia = (from r in _infojobsContext.recursos
                                    where r.tipo == "noticia"
                                    select new
                                    {
                                        fuente = r.fuente,
                                        titulo = r.titulo,
                                        imagen = r.imagen
                                    }).ToList();

            ViewData["listadoDeNoticia"] = listadoDeNoticia;

            var listadoDeArticulo = (from r in _infojobsContext.recursos
                                     where r.tipo == "articulo"
                                     select new
                                     {
                                         fuente = r.fuente,
                                         titulo = r.titulo,
                                         imagen = r.imagen
                                     }).ToList();

            ViewData["listadoDeArticulo"] = listadoDeArticulo;


            var listadoDeConsejo = (from r in _infojobsContext.recursos
                                    where r.tipo == "consejo"
                                    select new
                                    {
                                        titulo = r.titulo,
                                        descripcion = r.descripcion,
                                        imagen = r.imagen
                                    }).ToList();

            ViewData["listadoDeConsejo"] = listadoDeConsejo;


            var listadoDeVideo = (from r in _infojobsContext.recursos
                                  where r.tipo == "video"
                                  select new
                                  {
                                      fuente = r.fuente,
                                  }).ToList();

            ViewData["listadoDeVideo"] = listadoDeVideo;
        }

        public IActionResult buscar(string titulo) {
            var listadoDeOfer = (from o in _infojobsContext.oferta join e in
                                 _infojobsContext.empresa on o.id_empresa equals e.id_empresa
                                 where o.titulo.Contains(titulo)
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

                                 }).ToList();
            ViewData["listadoDeOfer"] = listadoDeOfer;

            var listadoDeNoticia = (from r in _infojobsContext.recursos
                                    where r.tipo == "noticia"
                                    select new
                                    {
                                        fuente = r.fuente,
                                        titulo = r.titulo,
                                        imagen = r.imagen
                                    }).ToList();

            ViewData["listadoDeNoticia"] = listadoDeNoticia;

            var listadoDeArticulo = (from r in _infojobsContext.recursos
                                     where r.tipo == "articulo"
                                     select new
                                     {
                                         fuente = r.fuente,
                                         titulo = r.titulo,
                                         imagen = r.imagen
                                     }).ToList();

            ViewData["listadoDeArticulo"] = listadoDeArticulo;


            var listadoDeConsejo = (from r in _infojobsContext.recursos
                                    where r.tipo == "consejo"
                                    select new
                                    {
                                        titulo = r.titulo,
                                        descripcion = r.descripcion,
                                        imagen = r.imagen
                                    }).ToList();

            ViewData["listadoDeConsejo"] = listadoDeConsejo;


            var listadoDeVideo = (from r in _infojobsContext.recursos
                                  where r.tipo == "video"
                                  select new
                                  {
                                      fuente = r.fuente,
                                  }).ToList();

            ViewData["listadoDeVideo"] = listadoDeVideo;

            return View("Index", listadoDeOfer);
        }

        public IActionResult quitarFiltro()
        {
            var listadoDeOfer = (from o in _infojobsContext.oferta
                                 join e in
                                 _infojobsContext.empresa on o.id_empresa equals e.id_empresa
                                 select new
                                 {
                                     id_empresa = o.id_empresa,
                                     nombre = e.nombre,
                                     descripcion=o.descripcion,
                                     logo = e.logo,
                                     id_oferta = o.id_oferta,
                                     titulo = o.titulo,
                                     ubicacion = o.ubicacion,
                                     requisitos = o.requisitos,
                                     contacto = o.contacto

                                 }).ToList();
            ViewData["listadoDeOfer"] = listadoDeOfer;

            var listadoDeNoticia = (from r in _infojobsContext.recursos
                                    where r.tipo == "noticia"
                                    select new
                                    {
                                        fuente = r.fuente,
                                        titulo = r.titulo,
                                        imagen = r.imagen
                                    }).ToList();

            ViewData["listadoDeNoticia"] = listadoDeNoticia;

            var listadoDeArticulo = (from r in _infojobsContext.recursos
                                     where r.tipo == "articulo"
                                     select new
                                     {
                                         fuente = r.fuente,
                                         titulo = r.titulo,
                                         imagen = r.imagen
                                     }).ToList();

            ViewData["listadoDeArticulo"] = listadoDeArticulo;


            var listadoDeConsejo = (from r in _infojobsContext.recursos
                                    where r.tipo == "consejo"
                                    select new
                                    {
                                        titulo = r.titulo,
                                        descripcion = r.descripcion,
                                        imagen = r.imagen
                                    }).ToList();

            ViewData["listadoDeConsejo"] = listadoDeConsejo;


            var listadoDeVideo = (from r in _infojobsContext.recursos
                                  where r.tipo == "video"
                                  select new
                                  {
                                      fuente = r.fuente,
                                  }).ToList();

            ViewData["listadoDeVideo"] = listadoDeVideo;

            return View("Index", listadoDeOfer);
        }
    }
}



