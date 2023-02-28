using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace GraveTracker.Areas.Frostgrave.Models
{
    public class WizardRepository : IWizardRepository
    {
        private readonly GraveTrackerDbContext _graveTrackerDbContext;

        public WizardRepository(GraveTrackerDbContext graveTrackerDbContext)
        {
            _graveTrackerDbContext = graveTrackerDbContext;
        }
        public IEnumerable<Wizard> AllWizards 
        {
            get 
            {
                return _graveTrackerDbContext.Wizards
                    .Include(s => s.SpellSchool)
                    .Include(s => s.KnownSpells)
                    .Select(wizard => new Wizard
                    {
                        WizardId = wizard.WizardId,
                        Name = wizard.Name,
                        Level = wizard.Level,
                        Experience = wizard.Experience,
                        SpellSchool = wizard.SpellSchool,
                        Move = wizard.Move,
                        Fight = wizard.Fight,
                        Shoot = wizard.Shoot,
                        Armour = wizard.Armour,
                        Will = wizard.Will,
                        MaxHealth = wizard.MaxHealth,
                        Backstory = wizard.Backstory,
                        Items = wizard.Items ?? new List<FGItem>(),
                        Injuries = wizard.Injuries ?? new List<FGInjury>(),
                        KnownSpells = wizard.KnownSpells ?? new List<Spell>()
                    });
            }
        }

        public Wizard? GetWizardByID(int wizardId)
        {
            var wizard = _graveTrackerDbContext.Wizards
            .Include(s => s.SpellSchool)
            .Include(s => s.KnownSpells)
            .Include(i => i.Items)
            .Include(i => i.Injuries)
            .FirstOrDefault(c => c.WizardId == wizardId);

            if (wizard != null)
            { 
                if (wizard.KnownSpells == null)
                {
                    wizard.KnownSpells = new List<Spell>();
                    _graveTrackerDbContext.SaveChanges();
                }

                if (wizard.KnownSpells != null)
                {
                    foreach (var spell in wizard.KnownSpells)
                    {
                        spell.SpellSchool = _graveTrackerDbContext.SpellSchools.FirstOrDefault(x => x.Spells.Any(s => s.SpellId == spell.SpellId));
                    }
                }
            }
            return wizard;
        }

        public int UpdateWizard(Wizard WizardToUpdate)
        {
            var existingWizard = GetWizardByID(WizardToUpdate.WizardId);

            if(existingWizard == null)
            {
                _graveTrackerDbContext.Wizards.Add(WizardToUpdate);
            }
            else
            {
                _graveTrackerDbContext.Entry(existingWizard).CurrentValues.SetValues(WizardToUpdate);

                existingWizard.KnownSpells.Clear();
                if (WizardToUpdate.KnownSpells != null)
                {
                    foreach (var spell in WizardToUpdate.KnownSpells)
                    {
                        spell.Wizards ??= new List<Wizard>();
                        spell.Wizards.Add(existingWizard);
                        _graveTrackerDbContext.Update(spell);

                        existingWizard.KnownSpells.Add(spell);
                    }
                }

                existingWizard.SpellSchool = WizardToUpdate.SpellSchool;
            }
            _graveTrackerDbContext.SaveChanges();

            return WizardToUpdate.WizardId;            
        }
    }
}
