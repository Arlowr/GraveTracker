namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGItem
    {
        public int FGItemId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Type { get; set; } = string.Empty;
        public int Price { get; set; }
        public string? Size { get; set; }
    }
}
