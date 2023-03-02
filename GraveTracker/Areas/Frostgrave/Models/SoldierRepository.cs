using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class SoldierRepository : ISoldierRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public SoldierRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Soldier> AllSoldiers
        {
            get {
                return _graveTrackerDbContext.Soldiers
                    .Include(s => s.Items)
                    .Include(s => s.Weapons)
                    .Include(s => s.Armours)
                    .OrderBy(x => x.SoldierId);
            }
        }

        public Soldier? GetSoldiersByID(int soldierId)
        {
            return _graveTrackerDbContext.Soldiers.FirstOrDefault(x => x.SoldierId == soldierId);
        }
    }
}
