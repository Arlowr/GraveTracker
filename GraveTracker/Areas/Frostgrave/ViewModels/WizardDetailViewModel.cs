using GraveTracker.Areas.Frostgrave.Models;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class WizardDetailViewModel
    {
        public Wizard? Wizard { get; }
        public bool ShowSpells { get; }
        public WizardDetailViewModel(Wizard wizard, bool showSpells)
        {
            Wizard = wizard;
            ShowSpells= showSpells;
        }
    }
}
