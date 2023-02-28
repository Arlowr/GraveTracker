using GraveTracker.Areas.Frostgrave.Models;
using Newtonsoft.Json;

namespace GraveTracker.Areas.Frostgrave.ViewModels
{
    public class EditWizardViewModel
    {
        public Wizard Wizard { get; set; }
        public string PageTitle { get; set; }
        public string ButtonText { get; set; }
        public List<SpellSchool> SpellSchoolList { get; set; }
        public List<TempSpell> AvailableSpells { get; set; }
        public List<TempSpell> KnownSpellsList { get; set; }
        public string? knownSpellsListJson { get; set; }

        public EditWizardViewModel() {}
        public EditWizardViewModel(Wizard wizardBeingEdited, bool newWizard, List<TempSpell> availableSpells, List<SpellSchool> spellSchools)
        {
            Wizard = wizardBeingEdited;
            KnownSpellsList= new List<TempSpell>();
            var tempAvailSpells = new List<Spell>();
            if (Wizard.KnownSpells != null)
            {
                foreach (var spell in Wizard.KnownSpells)
                {
                    TempSpell temp = new TempSpell() { SpellId = spell.SpellId, SpellName = spell.SpellName };
                    KnownSpellsList.Add(temp);

                    
                }
            }
            knownSpellsListJson = JsonConvert.SerializeObject(KnownSpellsList);
            AvailableSpells = availableSpells;

            if (newWizard)
            {
                PageTitle = "Create a new Wizard";
                ButtonText = "Create Wizard";
            }
            else
            {
                PageTitle = "Edit " + Wizard.Name;
                ButtonText = "Update Wizard";
            }

            SpellSchoolList = spellSchools; 
            var selectedValue = Wizard.SpellSchool?.SpellSchoolName;
            if (selectedValue != null)
            {
                var selectedSpellSchool = SpellSchoolList.FirstOrDefault(s => s.SpellSchoolName == selectedValue);
            }
        }
    }

}
