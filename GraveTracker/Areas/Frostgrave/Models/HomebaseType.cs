namespace GraveTracker.Areas.Frostgrave.Models
{
    public class HomebaseType
    {
        public int HomebaseTypeId { get; set; }
        public string? BaseTypeName { get; set; }
        public string BaseTypePower { get; set; } = string.Empty;
    }
}
