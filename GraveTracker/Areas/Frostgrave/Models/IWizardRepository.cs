namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IWizardRepository
    {
        IEnumerable<Wizard> AllWizards { get; }
        Wizard? GetWizardByID(int wizardId);
        int UpdateWizard(Wizard wizard);
    }
}
