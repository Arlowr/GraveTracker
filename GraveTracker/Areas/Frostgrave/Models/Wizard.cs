using System.ComponentModel.DataAnnotations.Schema;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Wizard : FGCharacterBase
    {
        public int WizardId { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public SpellSchool SpellSchool { get; set; } = default!;
        public List<Spell>? KnownSpells { get; set; }
    }
}
