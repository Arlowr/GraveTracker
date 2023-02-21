using GraveTracker.Areas.Frostgrave.Models;
using GraveTracker.Areas.Frostgrave.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GraveTracker.Areas.Frostgrave.Controllers
{
    [Area("Frostgrave")]
    public class WizardController : Controller
    {
        public readonly IWizardRepository _wizardRepository;
        public WizardController(IWizardRepository wizardRepository)
        {
            _wizardRepository = wizardRepository;
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
    }
}
