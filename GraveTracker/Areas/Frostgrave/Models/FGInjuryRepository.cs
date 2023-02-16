using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGInjuryRepository : IFGInjuryRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public FGInjuryRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<FGInjury> AllInjuries => _graveTrackerDbContext.FGInjuries.OrderBy(i => i.FGInjuryId);
    }
}
