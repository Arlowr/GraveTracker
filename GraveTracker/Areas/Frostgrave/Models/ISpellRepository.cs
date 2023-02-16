namespace GraveTracker.Areas.Frostgrave.Models
{
    public interface ISpellRepository
    {

        IEnumerable<Spell> AllSpells { get; }
        Spell? GetSpellByID(int spellId);
        IEnumerable<Spell> GetSpellsBySchool(int schoolId);
    }
}
