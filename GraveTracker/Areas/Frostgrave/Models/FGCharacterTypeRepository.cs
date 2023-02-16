using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterTypeRepository : IFGCharacterTypeRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public FGCharacterTypeRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }

        public IEnumerable<FGCharacterType> AllCharacterTypes
        {
            get { return _graveTrackerDbContext.FGCharacterTypes.Include(t => t.FGCharacterSuperType); }
        }

        public IEnumerable<FGCharacterType> CharacterTypesBySuperType(FGCharacterSuperType superType)
        {
            return _graveTrackerDbContext.FGCharacterTypes.Where(t => t.FGCharacterSuperType == superType);
        }

}
}
