namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGCharacterSuperType
    {
        public int FGCharacterSuperTypeId { get; set; }
        public string FGCharacterSuperTypeName { get; set;} = string.Empty;
        public List<FGCharacterType>? MyProperty { get; set; }
    }
}
