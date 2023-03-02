using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterBase
    {
        [Required(ErrorMessage = "Please enter a character name")]
        public string Name { get; set; } = string.Empty;
        [DefaultValue(6)]
        public int Move { get; set; }
        [DefaultValue(0)]
        public int Fight { get; set; }
        [DefaultValue(0)]
        public int Shoot { get; set; }
        [DefaultValue(10)]
        public int Armour { get; set; }
        [DefaultValue(10)]
        public int Will { get; set; }
        [DefaultValue(10)]
        public int MaxHealth { get; set; }
        public string? Backstory { get; set; }
        public List<FGItem>? Items { get; set; }
        public List<FGInjury>? Injuries { get; set; }
        public List<FGWeapon>? Weapons { get; set; }
        public List<FGArmour>? Armours { get; set;}
    }
}
