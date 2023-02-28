using GraveTracker.Areas.Frostgrave.Models;
using Microsoft.AspNetCore.Components.Web;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class EditWarbandViewModel
    {
        public Warband Warband { get; set; }
        public string PageTitle { get; set; }
        public string ButtonText { get; set; }
        public List<Wizard> WizardList { get; set; }
        public EditWarbandViewModel() { }
        public EditWarbandViewModel(Warband warband, bool newWarband, List<Wizard> wizardList)
        {
            Warband = new Warband();
            Warband = warband;
            WizardList = wizardList;

            if (newWarband)
            {
                PageTitle = "Create a new Warband";
                ButtonText = "Create Warband";
            }
            else
            {
                PageTitle = "Edit " + Warband.WarbandName;
                ButtonText = "Update Warband";
            }
        }
    }
}
