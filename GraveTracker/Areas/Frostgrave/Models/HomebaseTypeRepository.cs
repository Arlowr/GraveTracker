using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class HomebaseTypeRepository : IHomebaseTypeRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public HomebaseTypeRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<HomebaseType> AllHomebaseTypes => _graveTrackerDbContext.HomebaseTypes.OrderBy(i => i.HomebaseTypeId);
    }
}
