namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGCharacterRepository
    {
        IEnumerable<FGCharacter> AllCharacters { get; }
        FGCharacter? GetCharacterByID(int characterId);
    }
}
