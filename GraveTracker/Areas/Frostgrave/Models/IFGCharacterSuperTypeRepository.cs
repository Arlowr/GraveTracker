namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGCharacterSuperTypeRepository
    {
        IEnumerable<FGCharacterSuperType> AllCharacterSuperTypes { get; }
    }
}
