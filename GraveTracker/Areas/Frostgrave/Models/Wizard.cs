using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Wizard : FGCharacterBase
    {
        public int WizardId { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Level { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int Experience { get; set; }
        [Required(ErrorMessage = "A wizard must be specialised.")]
        public SpellSchool SpellSchool { get; set; } = default!;
        public List<Spell>? KnownSpells { get; set; }
    }
}
