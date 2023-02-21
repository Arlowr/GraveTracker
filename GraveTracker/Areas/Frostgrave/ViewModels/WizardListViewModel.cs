using GraveTracker.Areas.Frostgrave.Models;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class WizardListViewModel
    {
        public IEnumerable<Wizard> Wizards { get; }
        public WizardListViewModel(IEnumerable<Wizard> wizards)
        {
            Wizards = wizards;
        }
    }
}
