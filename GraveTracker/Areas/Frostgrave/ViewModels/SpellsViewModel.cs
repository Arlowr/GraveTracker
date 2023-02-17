using GraveTracker.Areas.Frostgrave.Models;
using System.IO.Pipelines;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class SpellsViewModel
    {
        public IEnumerable<SpellSchool> SpellSchools { get; set; }
        public SpellsViewModel(IEnumerable<SpellSchool> spellSchools)
        {
            SpellSchools = spellSchools;
        }

    }
}
