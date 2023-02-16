namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IHomebaseTypeRepository
    {
        IEnumerable<HomebaseType> AllHomebaseTypes { get; }
    }
}
