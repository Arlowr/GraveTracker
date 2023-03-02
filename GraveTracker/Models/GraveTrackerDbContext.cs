using GraveTracker.Areas.Frostgrave.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Models
{
    public class GraveTrackerDbContext: DbContext
    {
        public GraveTrackerDbContext(DbContextOptions<GraveTrackerDbContext> options) : base(options) { }

        public DbSet<FGCharacterType> FGCharacterTypes { get; set; }
        public DbSet<FGCharacterSuperType> FGCharacterSuperTypes { get; set; }
        public DbSet<FGItem> FGItems { get; set; }
        public DbSet<FGInjury> FGInjuries { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<SpellSchool> SpellSchools { get; set; }
        public DbSet<Soldier> Soldiers { get; set; }
        public DbSet<Wizard> Wizards { get; set; }
        public DbSet<Apprentice> Apprentices { get; set; }
        public DbSet<Homebase> Homebases { get; set; }
        public DbSet<HomebaseType> HomebaseTypes { get; set; }
        public DbSet<Warband> Warbands { get; set; }
        public DbSet<FGWeapon> FGWeapons { get; set; }
        public DbSet<FGArmour> FGArmours { get; set; }

    }
}
