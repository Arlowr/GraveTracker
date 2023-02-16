using System.ComponentModel.DataAnnotations.Schema;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Warband
    {
        public int WarbandId { get; set; }
        public string WarbandName { get; set; } = string.Empty;
        public Wizard Wizard { get; set; } = default!;
        public FGCharacter Apprentice { get; set; } = default!;
        public List<FGCharacter>? Soldiers { get; set; }
        public Homebase? Homebase { get; set; }
        public List<FGItem>? Vault { get; set; }
        public int Treasury { get; set; }
    }
}
