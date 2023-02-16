namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IHomebaseRepository
    {
        IEnumerable<Homebase> AllBases { get; }
        Homebase? GetHomebaseByID(int baseId);
    }
}
