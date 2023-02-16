using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class HomebaseRepository : IHomebaseRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;
        public HomebaseRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Homebase> AllBases
        {
            get { return _graveTrackerDbContext.Homebases.Include(t => t.BaseType); }
        }

        public Homebase? GetHomebaseByID(int baseId)
        {
            return _graveTrackerDbContext.Homebases.FirstOrDefault(c => c.HomebaseId == baseId);
        }
    }
}
