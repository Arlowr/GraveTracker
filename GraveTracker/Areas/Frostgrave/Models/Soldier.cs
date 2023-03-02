namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Soldier: FGCharacterBase
    {
        public int SoldierId { get; set; }
        public FGCharacterType characterType { get; set; }
        public string Ability { get; set; }
    }
}
