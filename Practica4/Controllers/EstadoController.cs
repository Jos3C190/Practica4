using Microsoft.AspNetCore.Mvc;
using Practica4.Data;
using Practica4.Models;

namespace Practica4.Controllers
{
    public class EstadoController : Controller
    {
        private readonly AgendaDbContext _context;

        public EstadoController(AgendaDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var listaEstados = _context.Estados.ToList();
            return View(listaEstados);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Estado estado)
        {
            if (ModelState.IsValid)
            {
                estado.CreateAt = DateTime.Now;

                _context.Estados.Add(estado);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estado);
        }
    }
}
