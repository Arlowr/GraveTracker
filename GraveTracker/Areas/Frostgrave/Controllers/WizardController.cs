using GraveTracker.Areas.Frostgrave.Models;
using GraveTracker.Areas.Frostgrave.ViewModels;
using GraveTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GraveTracker.Areas.Frostgrave.Controllers
{
    [Area("Frostgrave")]
    public class WizardController : Controller
    {
        public readonly IWizardRepository _wizardRepository;
        public readonly ISpellRepository _spellRepository;
        public readonly ISpellSchoolRepository _spellSchoolrepository;
        public WizardController(IWizardRepository wizardRepository, ISpellRepository spellRepository, ISpellSchoolRepository spellSchoolRepository)
        {
            _wizardRepository = wizardRepository;
            _spellRepository = spellRepository;
            _spellSchoolrepository= spellSchoolRepository;
        }

        public ViewResult List()
        {
            IEnumerable<Wizard> wizards;
            wizards = _wizardRepository.AllWizards.OrderBy(w => w.WizardId);

            return View(new WizardListViewModel(wizards));
        }
        public IActionResult Details(int id)
        {
            var wizard = _wizardRepository.GetWizardByID(id);
            if (wizard == null)
                return NotFound();
            return View(new WizardDetailViewModel(wizard,true));
        }

        [HttpPost]
        public IActionResult Filter(string filterText)
        {
            // Perform the search using the search text
            IEnumerable<Wizard> wizards;
            wizards = _wizardRepository.AllWizards.OrderBy(w => w.WizardId);
            IEnumerable<Wizard> filteredWizards = wizards.Where(x => x.Name.Contains(filterText));

            if (!filteredWizards.Any())
            {
                return Content("No wizards found.");
            }

            // Pass the search results to the partial view
            return PartialView("_FilteredWizardList", new WizardListViewModel(filteredWizards));
        }

        public IActionResult EditWizard(int wizardID) // GET
        {
            bool newWizard;
            Wizard wizard;
            List<Spell> tempAvailSpells;
            if (wizardID != 0)
            {
                wizard = _wizardRepository.GetWizardByID(wizardID);
                newWizard = false;
                tempAvailSpells = new List<Spell>();
                tempAvailSpells = _spellRepository.AllSpells.Where(s => !s.Wizards.Contains(wizard)).ToList();
            } else
            { 
                wizard = new Wizard();
                newWizard = true;
                tempAvailSpells = _spellRepository.AllSpells.ToList();
            }

            var AvailableSpells = new List<TempSpell>();
            foreach (var spell in tempAvailSpells)
            {
                TempSpell temp = new TempSpell() { SpellId = spell.SpellId, SpellName = spell.SpellName };
                AvailableSpells.Add(temp);
            }

            var SpellSchools = new List<SpellSchool>();
            SpellSchools = _spellSchoolrepository.AllSpellSchools.ToList();

            return View(new EditWizardViewModel(wizard, newWizard, AvailableSpells, SpellSchools));
        }

        [HttpPost]
        public IActionResult EditWizard(EditWizardViewModel wizardDetails) 
        {
            List<TempSpell> tempKnownSpells = new List<TempSpell> { };
            if (wizardDetails.knownSpellsListJson != null)
            {
                tempKnownSpells = JsonConvert.DeserializeObject<List<TempSpell>>(wizardDetails.knownSpellsListJson);
            }

            wizardDetails.Wizard.KnownSpells = new List<Spell>();
            if (tempKnownSpells != null)
            {
                foreach (var spell in tempKnownSpells)
                {
                    wizardDetails.Wizard.KnownSpells.Add(_spellRepository.GetSpellByID(spell.SpellId));
                }
            }

            if (wizardDetails.Wizard.SpellSchool.SpellSchoolId == 0)
            {
                wizardDetails.Wizard.SpellSchool = _spellSchoolrepository.AllSpellSchools.FirstOrDefault(x => x.SpellSchoolName == wizardDetails.Wizard.SpellSchool.SpellSchoolName);
            }

            var newWizardId = _wizardRepository.UpdateWizard(wizardDetails.Wizard);

            return RedirectToAction("Details", new { id = newWizardId });
        }
    }
}
