using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class WizardRepository : IWizardRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public WizardRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Wizard> AllWizards 
        {
            get { return _graveTrackerDbContext.Wizards.Include(s => s.SpellSchool); }
        }

        public Wizard? GetWizardByID(int wizardId)
        {
            return _graveTrackerDbContext.Wizards.Include(s => s.SpellSchool).Include(s => s.KnownSpells).FirstOrDefault(c => c.WizardId == wizardId);
        }
    }
}
