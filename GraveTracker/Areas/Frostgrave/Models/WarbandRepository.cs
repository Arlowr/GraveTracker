using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class WarbandRepository : IWarbandRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public WarbandRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Warband> AllWarbands => _graveTrackerDbContext.Warbands.OrderBy(t => t.WarbandId);

        public Warband? GetWarbandById(int warbandId)
        {
            return _graveTrackerDbContext.Warbands.FirstOrDefault(c => c.WarbandId == warbandId);
        }

        public IEnumerable<Warband> SearchWarbands(string searchQuery)
        {
            return _graveTrackerDbContext.Warbands.Where(p => p.WarbandName.Contains(searchQuery));
        }
    }
}
