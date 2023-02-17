namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterBase
    {
        public string Name { get; set; } = string.Empty;
        public int Move { get; set; }
        public int Fight { get; set; }
        public int Shoot { get; set; }
        public int Armour { get; set; }
        public int Will { get; set; }
        public int MaxHealth { get; set; }
        public string? Backstory { get; set; }
        public List<FGItem>? Items { get; set; }
        public List<FGInjury>? Injuries { get; set; }
    }
}
