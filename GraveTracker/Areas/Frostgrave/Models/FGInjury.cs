namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGInjury
    {
        public int FGInjuryId { get; set; }
        public string InjuryName { get; set; } = string.Empty;
        public string Effect { get; set; } = string.Empty;
    }
}
