using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class SpellSchoolRepository : ISpellSchoolRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public SpellSchoolRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<SpellSchool> AllSpellSchools => _graveTrackerDbContext.SpellSchools.OrderBy(t => t.SpellSchoolId);
    }
}
