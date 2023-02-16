namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Spell
    {
        public int SpellId { get; set; }
        public string SpellName { get; set; } = string.Empty;
        public int CastingNumber { get; set; }
        public string SpellDescription { get; set; } = string.Empty;
        public string SpellType { get; set; } = string.Empty;
        public SpellSchool SpellSchool { get; set; } = default!;
    }
}
