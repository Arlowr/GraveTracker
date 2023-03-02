namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGArmourRepository : IFGArmourRepository
    {
        public IEnumerable<FGArmour> AllArmnours => throw new NotImplementedException();

        public FGArmour? GetArmoursByID(int armourId)
        {
            throw new NotImplementedException();
        }
    }
}
