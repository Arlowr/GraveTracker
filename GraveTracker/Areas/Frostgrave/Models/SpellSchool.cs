namespace GraveTracker.Areas.Frostgrave.Models
{
    public class SpellSchool
    {
        public int SpellSchoolId { get; set; }
        public string SpellSchoolName { get; set; } = string.Empty;
        public string? SpellSchoolDescription { get; set; }
        public List<Spell>? Spells { get; set; }
    }
}
