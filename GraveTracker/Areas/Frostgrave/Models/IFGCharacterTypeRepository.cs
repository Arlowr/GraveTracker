namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGCharacterTypeRepository
    {
        IEnumerable<FGCharacterType> AllCharacterTypes { get; }
        IEnumerable<FGCharacterType> CharacterTypesBySuperType(FGCharacterSuperType superType);
    }
}
