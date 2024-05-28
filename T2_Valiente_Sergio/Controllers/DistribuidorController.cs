using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using T2_Valiente_Sergio.Datos;
using T2_Valiente_Sergio.Models;

namespace T2_Valiente_Sergio.Controllers
{
    public class DistribuidorController : Controller
    {
        private readonly ApplicationDbContext _db;

        public DistribuidorController(ApplicationDbContext db)
        {
            _db = db;
        }

        //Mostrar lista de distribuidores
        public IActionResult Index()
        {
            IEnumerable<Distribuidor> lista = _db.distribuidor;
            return View(lista);
        }


        //Get Agregar
        public IActionResult Agregar()
        {
            return View();
        }

        //Post Agregar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Agregar(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
            {
                _db.distribuidor.Add(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(distribuidor);
        }

        //Get Editar
        public IActionResult Editar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.distribuidor.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Editar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Distribuidor distribuidor)
        {
            if (ModelState.IsValid)
        {
            _db.distribuidor.Update(distribuidor);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(distribuidor);
    } 
    
        //Get Eliminar
        public IActionResult Eliminar(int? Id)
        {
            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var obj = _db.distribuidor.Find(Id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        //Post Eliminar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar(Distribuidor distribuidor)
        {
            if (distribuidor == null)
            {
                return NotFound();
            }
                _db.distribuidor.Remove(distribuidor);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
        //Mostrar principales distribuidores en el Perú
        public IActionResult Destacados_PE()
        {
            return View();
        }

        //Mostrar principales distribuidores en el mundo
        public IActionResult Destacados()
        {
            return View();
        }
    }
}
