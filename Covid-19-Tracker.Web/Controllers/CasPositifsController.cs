using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Covid_19_Tracker.Persistence.Repositories.Interfaces;
using Covid_19_Tracker.Web.Models;
using Covid_19_Tracker.Web.Mappers;
using Covid_19_Tracker.Web.Mappers.ExcelExport;
using System.Collections.Immutable;
using OfficeOpenXml;

namespace Covid_19_Tracker.Web.Controllers
{
    public class CasPositifsController : Controller
    {
        private readonly ICasPositifRepository _casPositifRepository;
        private readonly ICasSuiviRepository _casSuiviRepository;
        private const string ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";

        public CasPositifsController(ICasPositifRepository casPositifRepository)
        {
            _casPositifRepository = casPositifRepository;
        }

        // GET: CasPositifs
        public async Task<IActionResult> Index()
        {
            var casPositifs = await _casPositifRepository.GetAll();
            var models = casPositifs.ToCasPositifViewModel();
            return View(models);
        }

        // GET: CasPositifs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casSuivis = await _casPositifRepository.GetCasSuivis(id.Value); ;
            if (casSuivis == null)
            {
                return NotFound();
            }

            var model = casSuivis.ToCasSuiviViewModel();
            return View(model);
        }

        // GET: CasPositifs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CasPositifs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CasPositifViewModel model)
        {
            if (ModelState.IsValid)
            {
                var casPositif = model.ToCasPositifEntity();
                await _casPositifRepository.Add(casPositif);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        // GET: CasPositifs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casPositif = await _casPositifRepository.Get(id.Value);
            if (casPositif == null)
            {
                return NotFound();
            }
            var model = casPositif.ToCasPositifViewModel();
            return View(model);
        }

        // POST: CasPositifs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CasPositifViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var casPositif = model.ToCasPositifEntity();
                    await _casPositifRepository.Update(casPositif);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await _casPositifRepository.Any(id))
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

        // GET: CasPositifs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var casPositif = await _casPositifRepository.Get(id.Value);
            if (casPositif == null)
            {
                return NotFound();
            }

            var model = casPositif.ToCasPositifViewModel();
            return View(model);
        }

        // POST: CasPositifs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var casPositif = await _casPositifRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> ExporterFichesDeSuiviEnExcel(int? id)
        {
            var casPositif = await _casPositifRepository.Get(id.Value);
            var nomDeFichier = $"{casPositif.Nom}{casPositif.Prenom}.xlsx";
            var fichierVide = File(default(byte[]), ContentType, nomDeFichier);
            var casSuivis = await _casPositifRepository.GetCasSuivis(id.Value);
            if (casSuivis == null)
            {
                return fichierVide;
            }
            using (var excelPackage = new ExcelPackage())
            {
                foreach (var casSuivi in casSuivis)
                {
                    var fichesDeSuivi = await _casSuiviRepository.GetFichesSuivi(casSuivi.Id);
                    var builder = ImmutableList.CreateBuilder<ExcelSuivi>();
                    foreach (var ficheDeSuivi in fichesDeSuivi)
                    {
                        ExcelSuivi suivi = EntitiesExtensions.ToExcelSuivi(ficheDeSuivi);
                        builder.Add(suivi);
                    }
                    var excelSuivis = builder.ToImmutable();
                    excelPackage.AjouterSuivi(excelSuivis);
                }
                return File(excelPackage.GetAsByteArray(), ContentType, nomDeFichier);
            }
        }
    }
}
