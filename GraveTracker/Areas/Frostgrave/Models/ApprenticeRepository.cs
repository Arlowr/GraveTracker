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
        public IEnumerable<Apprentice> GetApprentices 
        {
            get { return _graveTrackerDbContext.Apprentices.Include(i => i.Items).Include(i => i.Injuries).OrderBy(a => a.ApprenticeId); }
        }

        public Apprentice? GetApprenticeById(int apprenticeId)
        {
            return _graveTrackerDbContext.Apprentices.Include(i => i.Items).Include(i => i.Injuries).FirstOrDefault(c => c.ApprenticeId == apprenticeId);
        }

        public int UpdateApprentice(Apprentice apprentice)
        {
            var existingapprentice = GetApprenticeById(apprentice.ApprenticeId);

            if (existingapprentice == null)
            {
                _graveTrackerDbContext.Apprentices.Add(apprentice);
            }
            else
            {
                _graveTrackerDbContext.Entry(existingapprentice).CurrentValues.SetValues(apprentice);
            }
            _graveTrackerDbContext.SaveChanges();

            return apprentice.ApprenticeId;
        }
    }
}
