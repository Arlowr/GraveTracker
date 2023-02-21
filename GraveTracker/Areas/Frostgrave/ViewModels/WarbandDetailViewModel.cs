using GraveTracker.Areas.Frostgrave.Models;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class WarbandDetailViewModel
    {
        public Warband? Warband { get; }
        public List<FGCharacter> fGCharacters { get; }

        public WarbandDetailViewModel() 
        { 
        }
    }
}
