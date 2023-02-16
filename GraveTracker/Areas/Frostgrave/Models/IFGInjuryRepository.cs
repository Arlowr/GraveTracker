namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGInjuryRepository
    {
        IEnumerable<FGInjury> AllInjuries { get; }
    }
}
