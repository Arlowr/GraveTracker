using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGItemRepository : IFGItemRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public FGItemRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<FGItem> AllItems => _graveTrackerDbContext.FGItems.OrderBy(i => i.FGItemId);

        public FGItem? GetItemByID(int itemId)
        {
            return _graveTrackerDbContext.FGItems.FirstOrDefault(c => c.FGItemId == itemId);
        }
    }
}
