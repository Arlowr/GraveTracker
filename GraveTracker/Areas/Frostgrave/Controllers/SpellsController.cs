using GraveTracker.Areas.Frostgrave.Models;
using GraveTracker.Areas.Frostgrave.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GraveTracker.Areas.Frostgrave.Controllers
{
    [Area("Frostgrave")]
    public class SpellsController : Controller
    {
        private readonly ISpellSchoolRepository _spellSchoolRepository;
        public SpellsController(ISpellSchoolRepository spellSchoolRepository)
        {
            _spellSchoolRepository = spellSchoolRepository;
        }

        public ViewResult List()
        {
            IEnumerable<SpellSchool> spellSchools;

            spellSchools = _spellSchoolRepository.AllSpellSchools.OrderBy(s => s.SpellSchoolId);

            return View(new SpellsViewModel(spellSchools));
        }
    }
}
