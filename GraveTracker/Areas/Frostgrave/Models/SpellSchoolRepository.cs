using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class SpellSchoolRepository : ISpellSchoolRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public SpellSchoolRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<SpellSchool> AllSpellSchools 
        {
            get { return _graveTrackerDbContext.SpellSchools.Include(s => s.Spells); }
        }
    }
}
