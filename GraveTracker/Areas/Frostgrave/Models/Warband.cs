using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Warband
    {
        public int WarbandId { get; set; }
        [Required(ErrorMessage = "A Warband must have a name...")]
        public string WarbandName { get; set; } = string.Empty;
        public string WarbandDescription { get; set; } = string.Empty;
        [Required(ErrorMessage = "What is a warband without a wizard?")]
        public Wizard? Wizard { get; set; }
        public Apprentice? Apprentice { get; set; }
        public List<Soldier>? Soldiers { get; set; }
        public Homebase? Homebase { get; set; }
        public List<FGItem>? Vault { get; set; }
        public int Treasury { get; set; }
    }
}
