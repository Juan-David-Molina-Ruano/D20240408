using D20240408.EntidadesDeNegocio;
using D20240408.LogicaDeNegocio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace D20240408.UI.AppWebMVC.Controllers
{
    public class PersonaDController : Controller
    {
        readonly PersonaDBL _personaDBL;

        public PersonaDController(PersonaDBL personaDBL)
        {
            _personaDBL = personaDBL;
        }

        // GET: PersonaDController
        public async Task<ActionResult> Index(PersonaD personaD)
        {
            var personasD = await _personaDBL.Buscar(personaD);
            return View(personasD);
        }

        // GET: PersonaDController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var personasD = await _personaDBL.ObtenerPorId(new PersonaD { Id = id });
            return View(personasD);
        }

        // GET: PersonaDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PersonaDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(PersonaD personaD)
        {
            try
            {
                await _personaDBL.Crear(personaD);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaDController/Edit/5
        public async Task<ActionResult> Edit(int id)
        {
            var personasD = await _personaDBL.ObtenerPorId(new PersonaD { Id = id });
            return View(personasD);
        }


        // POST: PersonaDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(PersonaD personaD)
        {
            try
            {
                await _personaDBL.Modificar(personaD);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonaDController/Delete/5
        public async Task<ActionResult> Delete(int id)
        {
            var personasD = await _personaDBL.ObtenerPorId(new PersonaD { Id = id });
            return View(personasD);
        }

        // POST: PersonaDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id, PersonaD personaD)
        {
            try
            {
                await _personaDBL.Eliminar(personaD);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
