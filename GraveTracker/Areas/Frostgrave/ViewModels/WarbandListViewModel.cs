using GraveTracker.Areas.Frostgrave.Models;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class WarbandListViewModel
    {
        public IEnumerable<Warband> Warbands { get; }
        public WarbandListViewModel(IEnumerable<Warband> warbands)
        {
            Warbands = warbands;
        }
    }
}
