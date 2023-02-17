using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class ApprenticeRepository : IApprenticeRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;
        public ApprenticeRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Apprentice> GetApprentices => _graveTrackerDbContext.Apprentices.OrderBy(a => a.ApprenticeId); 

        public Apprentice? GetApprenticeById(int apprenticeId)
        {
            return _graveTrackerDbContext.Apprentices.FirstOrDefault(c => c.ApprenticeId == apprenticeId);
        }
    }
}
