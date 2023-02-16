using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class SpellRepository : ISpellRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;
        public SpellRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Spell> AllSpells
        {
            get { return _graveTrackerDbContext.Spells.Include(t => t.SpellSchool); }
        }

        public Spell? GetSpellByID(int spellId)
        {
            return _graveTrackerDbContext.Spells.FirstOrDefault(c => c.SpellId == spellId);
        }

        public IEnumerable<Spell> GetSpellsBySchool(int schoolId)
        {
            return _graveTrackerDbContext.Spells.Where(c => c.SpellSchool.SpellSchoolId == schoolId);
        }
    }
}
