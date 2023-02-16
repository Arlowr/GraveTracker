namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Apprentice: FGCharacterBase
    {
        public int ApprenticeId { get; set; }
        public Wizard Wizard { get; set; } = default!;
    }
}
