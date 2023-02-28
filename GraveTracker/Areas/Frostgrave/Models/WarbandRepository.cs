using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class WarbandRepository : IWarbandRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public WarbandRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Warband> AllWarbands
        {
            get { return _graveTrackerDbContext.Warbands.Include(w => w.Wizard).OrderBy(t => t.WarbandId); }
        }

        public Warband? GetWarbandById(int warbandId)
        {
            return _graveTrackerDbContext.Warbands.Include(w => w.Wizard).FirstOrDefault(c => c.WarbandId == warbandId);
        }

        public IEnumerable<Warband> SearchWarbands(string searchQuery)
        {
            return _graveTrackerDbContext.Warbands.Include(w => w.Wizard).Where(p => p.WarbandName.Contains(searchQuery));
        }

        public int UpdateWarband(Warband warband)
        {
            var existingwarband = GetWarbandById(warband.WarbandId);

            if (existingwarband == null)
            {
                _graveTrackerDbContext.Warbands.Add(warband);
            }
            else
            {
                _graveTrackerDbContext.Entry(existingwarband).CurrentValues.SetValues(warband);
            }
            _graveTrackerDbContext.SaveChanges();

            return warband.WarbandId;
        }
    }
}
