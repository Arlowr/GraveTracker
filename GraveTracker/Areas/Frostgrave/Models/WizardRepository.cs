using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class WizardRepository : IWizardRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public WizardRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Wizard> AllWizards => _graveTrackerDbContext.Wizards.OrderBy(t => t.WizardId);

        public Wizard? GetWizardByID(int wizardId)
        {
            return _graveTrackerDbContext.Wizards.FirstOrDefault(c => c.WizardId == wizardId);
        }
    }
}
