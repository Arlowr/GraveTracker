using GraveTracker.Areas.Frostgrave.Models;

namespace GraveTracker.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            GraveTrackerDbContext context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<GraveTrackerDbContext>();

            if (!context.SpellSchools.Any())
            {
                context.SpellSchools.AddRange(SpellSchools.Select(s => s.Value));
            }
            if (!context.Spells.Any(x => x.SpellSchool == SpellSchools["Chronomancer"]))
            {
                context.Spells.AddRange(ChronoSpells.Select(s => s.Value));
            }

            context.SaveChanges();
        }

        private static Dictionary<string, SpellSchool>? spellSchools;

        public static Dictionary<string, SpellSchool> SpellSchools
        {
            get
            {
                if (spellSchools == null)
                {
                    var spellsList = new SpellSchool[]
                    {
                        new SpellSchool { SpellSchoolName = "Chronomancer", SpellSchoolDescription = "Master of time magic"  },
                        new SpellSchool { SpellSchoolName = "Elementalist", SpellSchoolDescription = "Master of the elements (So anyway... I started blasting)"  },
                        new SpellSchool { SpellSchoolName = "Enchanter", SpellSchoolDescription = "Master of enhancement magic"  },
                        new SpellSchool { SpellSchoolName = "Illusionist", SpellSchoolDescription = "Master of trikcery magic"  },
                        new SpellSchool { SpellSchoolName = "Necromancer", SpellSchoolDescription = "Master of the dead"  },
                        new SpellSchool { SpellSchoolName = "Sigilist", SpellSchoolDescription = "Master of runic magic and knowledge"  },
                        new SpellSchool { SpellSchoolName = "Soothsayer", SpellSchoolDescription = "Master of divination and sight magic"  },
                        new SpellSchool { SpellSchoolName = "Summoner", SpellSchoolDescription = "Master of creation magic"  },
                        new SpellSchool { SpellSchoolName = "Thaumaturge", SpellSchoolDescription = "Master of wonders and miracles"  },
                        new SpellSchool { SpellSchoolName = "Witch", SpellSchoolDescription = "Master of wild magic"  }
                    };

                    spellSchools = new Dictionary<string, SpellSchool>();

                    foreach (SpellSchool school in spellsList)
                    {
                        spellSchools.Add(school.SpellSchoolName, school);
                    }
                }

                return spellSchools;
            }
        }
        private static Dictionary<string, Spell>? chronoSpells;

        public static Dictionary<string, Spell> ChronoSpells
        {
            get
            {
                if (chronoSpells == null)
                {
                    var spellsList = new Spell[]
                    {
                        new Spell { SpellName = "Crumble", CastingNumber = 10, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Line Of Sight", SpellDescription = "This spell can only target inanimate structures such as buildings and walls. The spellcaster rapidly speeds up the passing of time in a small area of the structure, causing it to collapse. This can create a doorway-sized hole through any wall, which should be indicated on the table somehow. The spell can also be used to collapse a section of floor beneath a figure standing on a level above the ground. In this case, the figure about to be affected must pass a Move Roll (TN22) or fall to the next level down and taking damage appropriately. If this spell is cast on a wall created by the Wall spell, the wall is completely destroyed. If it is cast on terrain holding a Wizard Eye, the Wizard Eye is cancelled." },
                        new Spell { SpellName = "Decay", CastingNumber = 12, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Line Of Sight", SpellDescription = "The spellcaster selects and attacks a target’s weapon, causing it to decay and fall apart, rendering it useless for the rest of the game. This spell has no effect on magic weapons (even those only temporarily enchanted). This spell has no effect on creatures (unless they are specifically identified as being equipped with a weapon from the General Arms and Armour List)." },
                        new Spell { SpellName = "Fast Act", CastingNumber = 8, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Line Of Sight", SpellDescription = "This spell may only be cast on a member of the spellcaster’s warband or an uncontrolled creature. This figure will activate at the end of the current phase instead of in its normal phase. For example, if an apprentice casts this spell on an uncontrolled creature, the creature will activate at the end of that player’s Apprentice phase instead of the Creature phase. Spellcasters may not cast this spell on themselves, nor on a figure that has already activated in the current turn." },
                        new Spell { SpellName = "Fleet Feet", CastingNumber = 10, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Line Of Sight", SpellDescription = "The target receives +2 Move for the rest of the game. Multiple castings of Fleet Foot on the same target have no effect." },
                        new Spell { SpellName = "Petrify", CastingNumber = 10, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Line Of Sight", SpellDescription = "The target figure must make an immediate Will Roll with a Target Number equal to the Casting Roll. If it fails, it receives no actions in its next activation. Furthermore, the figure suffers -3 Fight (to a minimum of +0) and may not have Leap cast upon it until after it makes its next move action. Large creatures receive +8 to their Will Roll to resist this spell." },
                        new Spell { SpellName = "Slow", CastingNumber = 10, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Line Of Sight", SpellDescription = "The target is reduced to a maximum of one action per activation (which can be any action, it does not have to be movement). It may make an Will Roll verses the Casting Roll at the end of each of its activations. If successful the spell is cancelled." },
                        new Spell { SpellName = "Time Store", CastingNumber = 14, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Self Only", SpellDescription = "The spellcaster captures a fragment of their own present to save for future use. To cast this spell, the spellcaster must be able to take two actions during their activation. They must spend the first action casting Time Store. If successful, the second action is lost. This spellcaster is now considered to have a stored ‘extra action’ that they may use in a future turn. This action can only be used during the spellcaster’s activation and can give the spellcaster three actions in one activation." },
                        new Spell { SpellName = "Time Walk", CastingNumber = 14, SpellSchool = SpellSchools["Chronomancer"], SpellType = "Self Only", SpellDescription = "Wizard only. The wizard will activate again in the Apprentice phase and the Soldier phase. This is in addition to the figures that can normally activate in those phases. The wizard may not activate any additional soldiers or be part of a group activation in these phases. The wizard may perform one action in each of these two phases and may take any action – they are not limited to movement. If the wizard moved at all in a previous activation during the turn, any additional move actions are at half rate. If a wizard casts this spell in consecutive turns, they immediately suffer 8 points of damage." },
                    };

                    chronoSpells = new Dictionary<string, Spell>();

                    foreach (Spell spell in spellsList)
                    {
                        chronoSpells.Add(spell.SpellName, spell);
                    }
                }

                return chronoSpells;
            }
        }
    }
}
