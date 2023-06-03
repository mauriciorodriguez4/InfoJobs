using Firebase.Auth;
using Firebase.Storage;
using InfoJobs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace InfoJobs.Controllers
{
    public class HomeController : Controller
    {
        private readonly infojobsContext _infojobsContext;
        public HomeController(infojobsContext infojobsContext)
        {
            _infojobsContext = infojobsContext;
        }

        public IActionResult Index()
        {
            listas();
            return View();
        }

        /*Mostrar caruseel dinamico*/
        public void listas()
        {
            var listadoDeCar1 = (from r in _infojobsContext.empresa
                                 select new
                                 {
                                     logo = r.logo,
                                     nombre = r.nombre
                                 }).ToList();

            ViewData["listadoDeCar1"] = listadoDeCar1;

            var listadoDeCar2 = (from r in _infojobsContext.recursos
                                 where r.tipo == "consejo"
                                 select new
                                 {
                                     imagen = r.imagen,
                                     nombre = r.titulo,
                                     descripcion = r.descripcion
                                 }).ToList();

            ViewData["listadoDeCar2"] = listadoDeCar2;

            /*Obtener el top 3*/
            var trabajosMasSolicitados = (from t in _infojobsContext.trabajos
                                          select new
                                          {
                                              id = t.id_trabajo,
                                              trabajo = t.nombre,
                                              empresa = t.nombre_empresa,
                                              salario = t.salario,
                                              imagen = t.imagen
                                          }).ToList().OrderByDescending(t => t.salario).Take(3);
            ViewData["TrabajosTop"] = trabajosMasSolicitados;
        }

        public IActionResult busqueda(string ubicacion, string tipoTrabajo, string experiencia, int clasificacion)
        {

            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Para mostrar la vista propia de cada empleo
        // GET: Empleo/id
        public async Task<IActionResult> Empleo(int? id)
        {
            TempData["IdEmpleo"] = id;
            if (id == null || _infojobsContext.trabajos == null)
            {
                return NotFound();
            }

            var trabajos = await _infojobsContext.trabajos
                .FirstOrDefaultAsync(t => t.id_trabajo == id);
            if (trabajos == null)
            {
                return NotFound();
            }
            var listadoComen = (from c in _infojobsContext.comentarios
                                where c.id_trabajo == id
                                select new
                                {
                                    comentario = c.comentario,
                                    valoracion = c.valoracion,
                                }).ToList();
            ViewData["listadoComen"] = listadoComen;

            return View(trabajos);
        }

        // Crear un asesoramiento 
        public IActionResult CrearAsesoramiento(asesoramiento nuevoAsesoramiento)
        {
            _infojobsContext.Add(nuevoAsesoramiento);
            _infojobsContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<ActionResult> subirArchivo(IFormFile archivo)
        {
            if (archivo != null && archivo.OpenReadStream() != null)
            {
                Stream archivoS = archivo.OpenReadStream();
                string email = "cargar@gmail.com";
                string clave = "123456789";
                string ruta = "parcial-5d2b8.appspot.com";
                string api_key = "AIzaSyApcHXcbpK7je9WxUhwdwX7jmUcTh2SQpo";

                var auth = new FirebaseAuthProvider(new FirebaseConfig(api_key));
                var autenticar = await auth.SignInWithEmailAndPasswordAsync(email, clave);
                var cancelacion = new CancellationTokenSource();
                var tokenU = autenticar.FirebaseToken;

                var tareaCargar = new FirebaseStorage(ruta, new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(tokenU),
                    ThrowOnCancel = true
                }).Child("curriculums").Child(archivo.FileName).PutAsync(archivoS, cancelacion.Token);
                int idtrabajo2 = (int)TempData["IdEmpleo"];
                var URl = await tareaCargar;
                var nAplicante = new aplicante();
                nAplicante.id_trabajos = idtrabajo2;
                nAplicante.cv = URl;
                nAplicante.id_usuario = 2;
                nAplicante.Estado = 'P';
                AgregarAplicante(nAplicante);
                TempData["Mensaje"] = "El archivo se ha subido correctamente.";
                TempData["Mensaje2"] = "¡Gracias por aplicar! Tu solicitud para el trabajo ha sido enviada con éxito.";
            }
            else
            {
                TempData["Mensaje3"] = "Envío de currículum obligatorio para solicitud de empleo.";
            }
            int idtrabajo = (int)TempData["IdEmpleo"];
            return RedirectToAction("Empleo", "Home", new { id = idtrabajo});

        }

        public void AgregarAplicante(aplicante nAplicante)
        {
            _infojobsContext.Add(nAplicante);
            _infojobsContext.SaveChanges();

        }

        public IActionResult agregarComentario(comentarios nComentarios)
        {
            _infojobsContext.Add(nComentarios);
            _infojobsContext.SaveChanges();
            int idtrabajo = (int)TempData["IdEmpleo"];
            return RedirectToAction("Empleo", "Home", new { id = idtrabajo });

        }

        public IActionResult verComentarios()
        {
            
            int idtrabajo = (int)TempData["IdEmpleo"];
            var listadoComen = (from c in _infojobsContext.comentarios
                                 where c.id_trabajo == idtrabajo
                                 select new
                                 {
                                     comentario=c.comentario,
                                     valoracion=c.valoracion,
                                 }).ToList();
            ViewData["listadoComen"] = listadoComen;

            return RedirectToAction("Empleo", "Home", new { id = idtrabajo });

        }
    }
}