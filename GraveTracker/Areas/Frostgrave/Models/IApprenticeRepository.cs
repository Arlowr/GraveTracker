namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IApprenticeRepository
    {
        IEnumerable<Apprentice> GetApprentices { get; }
        Apprentice? GetApprenticeById(int apprenticeId);
    }
}
