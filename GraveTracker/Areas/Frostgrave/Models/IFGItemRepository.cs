namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGItemRepository
    {
        IEnumerable<FGItem> AllItems { get; }
        FGItem? GetItemByID(int itemId);
    }
}
