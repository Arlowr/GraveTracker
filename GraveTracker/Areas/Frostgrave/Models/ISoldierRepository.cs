namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface ISoldierRepository
    {
        IEnumerable<Soldier> AllSoldiers { get; }
        Soldier? GetSoldiersByID(int soldierId);
    }
}
