namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface IFGWeaponRepository
    {
        IEnumerable<FGWeapon> AllWeapons { get; }
        FGWeapon? GetWeaponsByID(int weaponId);
    }
}
