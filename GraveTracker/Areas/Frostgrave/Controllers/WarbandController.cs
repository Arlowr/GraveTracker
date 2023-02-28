﻿using GraveTracker.Areas.Frostgrave.Models;
using GraveTracker.Areas.Frostgrave.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace GraveTracker.Areas.Frostgrave.Controllers
{
    [Area("Frostgrave")]
    public class WarbandController : Controller
    {
        public readonly IWarbandRepository _warbandRepository;
        public readonly IWizardRepository _wizardRepository;
        public readonly IApprenticeRepository _apprenticeRepository;
        public WarbandController(IWarbandRepository warbandRepository, IWizardRepository wizardRepository, IApprenticeRepository apprenticeRepository)
        {
            _warbandRepository = warbandRepository;
            _wizardRepository = wizardRepository;
            _apprenticeRepository = apprenticeRepository;
        }
        public ViewResult List()
        {
            IEnumerable<Warband> warbands;
            warbands = _warbandRepository.AllWarbands.OrderBy(w => w.WarbandId);

            return View(new WarbandListViewModel(warbands));
        }
        [HttpPost]
        public IActionResult Filter(string filterText)
        {
            // Perform the search using the search text
            IEnumerable<Warband> warbands;
            warbands = _warbandRepository.AllWarbands.OrderBy(w => w.WarbandId);
            IEnumerable<Warband> filteredWarbands = warbands.Where(x => x.WarbandName.Contains(filterText));

            if (!filteredWarbands.Any())
            {
                return Content("No warbands found.");
            }

            // Pass the search results to the partial view
            return PartialView("_FilteredWarbandList", new WarbandListViewModel(filteredWarbands));
        }
        public IActionResult Details(int id)
        {
            var warband = _warbandRepository.GetWarbandById(id);
            if (warband == null)
                return NotFound();
            return View(warband);
        }

        public IActionResult EditWarband(int warbandID) // GET
        {
            bool newWarband;
            Warband warband = new Warband();
            if (warbandID != 0)
            {
                warband = _warbandRepository.GetWarbandById(warbandID);
                newWarband = false;
            }
            else
            {
                warband = new Warband();
                newWarband = true;
            }

            List<Wizard> allWizards = _wizardRepository.AllWizards.OrderBy(w => w.WizardId).ToList();

            return View(new EditWarbandViewModel(warband, newWarband, allWizards));
        }

        [HttpPost]
        public IActionResult EditWarband(Warband Warband)
        {
            if (Warband.Wizard.WizardId == 0)
            {
                Warband.Wizard = _wizardRepository.AllWizards.FirstOrDefault(x => x.Name == Warband.Wizard.Name);
            } 
            else
            {
                Warband.Wizard = _wizardRepository.GetWizardByID(Warband.Wizard.WizardId);
            }

            if(Warband.Apprentice != null)
            {
                if (Warband.Apprentice.Name != null)
                {
                    if (Warband.Apprentice.ApprenticeId == 0)
                    {
                        var tempApprentice = _apprenticeRepository.GetApprentices.FirstOrDefault(x => x.Name == Warband.Apprentice.Name);
                        if (tempApprentice != null)
                        {
                            Warband.Apprentice = tempApprentice;
                        }
                    }
                    Warband.Apprentice.Fight = Warband.Wizard.Fight - 2;
                    Warband.Apprentice.Shoot = Warband.Wizard.Shoot;
                    Warband.Apprentice.Armour = Warband.Wizard.Armour;
                    Warband.Apprentice.Will = Warband.Wizard.Will - 2;
                    Warband.Apprentice.MaxHealth = Warband.Wizard.MaxHealth - 2;

                    var newApprenticeId = _apprenticeRepository.UpdateApprentice(Warband.Apprentice);
                    Warband.Apprentice = _apprenticeRepository.GetApprenticeById(newApprenticeId);
                }
            }

            var newWarbandId = _warbandRepository.UpdateWarband(Warband);

            return RedirectToAction("Details", new { id = newWarbandId });
        }
    }
}
