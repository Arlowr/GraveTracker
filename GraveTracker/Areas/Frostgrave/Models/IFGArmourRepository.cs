namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGArmourRepository
    {
        IEnumerable<FGArmour> AllArmnours { get; }
        FGArmour? GetArmoursByID(int armourId);
    }
}
