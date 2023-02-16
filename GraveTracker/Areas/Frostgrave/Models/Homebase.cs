namespace GraveTracker.Areas.Frostgrave.Models
{
    public class Homebase
    {
        public int HomebaseId { get; set; }
        public string? BaseName { get; set; }
        public HomebaseType BaseType { get; set; } = default!;
        public string? BaseDescription { get; set; }

    }
}
