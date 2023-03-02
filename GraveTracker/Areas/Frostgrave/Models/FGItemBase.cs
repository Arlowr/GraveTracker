namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGItemBase
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Notes { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Size { get; set; }
        public List<Wizard>? Wizards { get; set; }
        public List<Apprentice>? Apprentices { get; set; }
        public List<Soldier>? Soldiers { get; set; }
        public List<FGCharacterType>? CharacterTypes { get; set; }
    }
}
