using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ComercioController : Controller
    {
        private readonly ComercioBussines _bussines;

        public ComercioController(ComercioBussines bussines)
        {
            _bussines = bussines;
        }

        ////////////////////// LISTAR //////////////////////
        public IActionResult Index()
        {
            var lista = _bussines.Listar();
            return View(lista);
        }

        ////////////////////// CREAR //////////////////////
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Comercio comercio)
        {
            if (!ModelState.IsValid)
                return View(comercio);

            _bussines.Registrar(comercio);

            return RedirectToAction("Index");
        }

        ////////////////////// EDITAR //////////////////////
        public IActionResult Edit(int id)
        {
            var comercio = _bussines.Obtener(id);
            return View(comercio);
        }

        [HttpPost]
        public IActionResult Edit(Comercio comercio)
        {
            _bussines.Editar(comercio);
            return RedirectToAction("Index");
        }

        ////////////////////// DETALLES //////////////////////
        public IActionResult Details(int id)
        {
            var comercio = _bussines.Obtener(id);
            return View(comercio);
        }
    }
}
