using GraveTracker.Models;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterSuperTypeRepository : IFGCharacterSuperTypeRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public FGCharacterSuperTypeRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<FGCharacterSuperType> AllCharacterSuperTypes => _graveTrackerDbContext.FGCharacterSuperTypes.OrderBy(t => t.FGCharacterSuperTypeName); 
    }
}
