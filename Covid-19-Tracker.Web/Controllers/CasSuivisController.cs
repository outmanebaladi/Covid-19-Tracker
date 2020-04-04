using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Persistence;
using Covid_19_Tracker.Persistence.Repositories.Interfaces;
using Covid_19_Tracker.Web.Mappers;
using Covid_19_Tracker.Web.Models;

namespace Covid_19_Tracker.Web.Controllers
{
    public class CasSuivisController : Controller
    {
        private readonly ICasSuiviRepository _casSuiviRepository;

        public CasSuivisController(ICasSuiviRepository casSuiviRepository)
        {
            _casSuiviRepository = casSuiviRepository;
        }

        // GET: CasSuivis
        public async Task<IActionResult> Index()
        {
            var casSuivis = await _casSuiviRepository.GetAll();
            var models = casSuivis.ToCasSuiviViewModel();
            return View(models);
        }

        // GET: CasSuivis/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CasSuivis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CasSuiviViewModel model)
        {
            if (ModelState.IsValid)
            {
                var casSuivi = model.ToCasSuiviEntity();
                casSuivi.FichesSuivi = new FicheSuivi[14];
                await _casSuiviRepository.Add(casSuivi);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }


        // GET: CasPositifs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fichesSuivi = await _casSuiviRepository.GetFichesSuivi(id.Value); ;
            if (fichesSuivi == null)
            {
                return NotFound();
            }

            var model = fichesSuivi.ToFicheSuiviViewModel();
            return View(model);
        }

            // GET: CasSuivis/Edit/5
            public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casSuivi = await _casSuiviRepository.Get(id.Value);
            if (casSuivi == null)
            {
                return NotFound();
            }
            var model = casSuivi.ToCasSuiviViewModel();
            return View(model);
        }

        // POST: CasSuivis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CasSuiviViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var casSuivi = model.ToCasSuiviEntity();
                    await _casSuiviRepository.Update(casSuivi);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _casSuiviRepository.Any(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: CasSuivis/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casSuivi = await _casSuiviRepository.Get(id.Value);
            if (casSuivi == null)
            {
                return NotFound();
            }

            var model = casSuivi.ToCasSuiviViewModel();
            return View(model);
        }

        // POST: CasSuivis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casSuivi = await _casSuiviRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
