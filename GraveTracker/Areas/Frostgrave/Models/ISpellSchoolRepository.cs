namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface ISpellSchoolRepository
    {
        IEnumerable<SpellSchool> AllSpellSchools { get; }
    }
}
