namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterType
    {
        public int FGCharacterTypeID { get; set; }
        public string CharacterTypeName { get; set; } = string.Empty;
        public int BaseMove { get; set; }
        public int BaseFight { get; set; }
        public int BaseShoot { get; set; }
        public int BaseArmour { get; set; }
        public int BaseWill { get; set; }
        public int BaseMaxHealth { get; set; }
        public List<FGItem>? BaseItems { get; set; }
        public FGCharacterSuperType FGCharacterSuperType { get; set; } = default!;
    }
}
