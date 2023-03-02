namespace GraveTracker.Areas.Frostgrave.Models
{
    public class FGWeaponRepository : IFGWeaponRepository
    {
        public IEnumerable<FGWeapon> AllWeapons => throw new NotImplementedException();

        public FGWeapon? GetWeaponsByID(int weaponId)
        {
            throw new NotImplementedException();
        }
    }
}
