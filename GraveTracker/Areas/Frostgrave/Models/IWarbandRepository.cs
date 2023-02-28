using System.IO.Pipelines;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IWarbandRepository
    {
        IEnumerable<Warband> AllWarbands { get; }
        Warband? GetWarbandById(int warbandId);
        IEnumerable<Warband> SearchWarbands(string searchQuery);
        int UpdateWarband(Warband warband);
    }
}
