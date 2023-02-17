namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacter : FGCharacterBase
    {
        public int FGCharacterId { get; set; }
        public FGCharacterType Type { get; set; } = default!;
    }
}
