using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterRepository : IFGCharacterRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;
        public FGCharacterRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }

        public IEnumerable<FGCharacter> AllCharacters
        {
            get { return _graveTrackerDbContext.FGCharacters.Include(t => t.Type); }
        }

        public FGCharacter? GetCharacterByID(int characterId)
        {
            return _graveTrackerDbContext.FGCharacters.FirstOrDefault(c => c.FGCharacterId == characterId);
        }
    }
}
