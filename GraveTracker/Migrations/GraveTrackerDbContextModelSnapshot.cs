﻿// <auto-generated />
using System;
using GraveTracker.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GraveTracker.Migrations
{
    [DbContext(typeof(GraveTrackerDbContext))]
    partial class GraveTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Apprentice", b =>
                {
                    b.Property<int>("ApprenticeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApprenticeId"), 1L, 1);

                    b.Property<int>("Armour")
                        .HasColumnType("int");

                    b.Property<string>("Backstory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fight")
                        .HasColumnType("int");

                    b.Property<int>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<int>("Move")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shoot")
                        .HasColumnType("int");

                    b.Property<int>("TypeFGCharacterTypeID")
                        .HasColumnType("int");

                    b.Property<int>("Will")
                        .HasColumnType("int");

                    b.Property<int>("WizardId")
                        .HasColumnType("int");

                    b.HasKey("ApprenticeId");

                    b.HasIndex("TypeFGCharacterTypeID");

                    b.HasIndex("WizardId");

                    b.ToTable("Apprentices");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacter", b =>
                {
                    b.Property<int>("FGCharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FGCharacterId"), 1L, 1);

                    b.Property<int>("Armour")
                        .HasColumnType("int");

                    b.Property<string>("Backstory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Fight")
                        .HasColumnType("int");

                    b.Property<int>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<int>("Move")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Shoot")
                        .HasColumnType("int");

                    b.Property<int>("TypeFGCharacterTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("WarbandId")
                        .HasColumnType("int");

                    b.Property<int>("Will")
                        .HasColumnType("int");

                    b.HasKey("FGCharacterId");

                    b.HasIndex("TypeFGCharacterTypeID");

                    b.HasIndex("WarbandId");

                    b.ToTable("FGCharacters");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacterSuperType", b =>
                {
                    b.Property<int>("FGCharacterSuperTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FGCharacterSuperTypeId"), 1L, 1);

                    b.Property<string>("FGCharacterSuperTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FGCharacterSuperTypeId");

                    b.ToTable("FGCharacterSuperTypes");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacterType", b =>
                {
                    b.Property<int>("FGCharacterTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FGCharacterTypeID"), 1L, 1);

                    b.Property<int>("BaseArmour")
                        .HasColumnType("int");

                    b.Property<int>("BaseFight")
                        .HasColumnType("int");

                    b.Property<int>("BaseMaxHealth")
                        .HasColumnType("int");

                    b.Property<int>("BaseMove")
                        .HasColumnType("int");

                    b.Property<int>("BaseShoot")
                        .HasColumnType("int");

                    b.Property<int>("BaseWill")
                        .HasColumnType("int");

                    b.Property<string>("CharacterTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FGCharacterSuperTypeId")
                        .HasColumnType("int");

                    b.HasKey("FGCharacterTypeID");

                    b.HasIndex("FGCharacterSuperTypeId");

                    b.ToTable("FGCharacterTypes");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGInjury", b =>
                {
                    b.Property<int>("FGInjuryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FGInjuryId"), 1L, 1);

                    b.Property<int?>("ApprenticeId")
                        .HasColumnType("int");

                    b.Property<string>("Effect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FGCharacterId")
                        .HasColumnType("int");

                    b.Property<string>("InjuryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WizardId")
                        .HasColumnType("int");

                    b.HasKey("FGInjuryId");

                    b.HasIndex("ApprenticeId");

                    b.HasIndex("FGCharacterId");

                    b.HasIndex("WizardId");

                    b.ToTable("FGInjuries");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGItem", b =>
                {
                    b.Property<int>("FGItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FGItemId"), 1L, 1);

                    b.Property<int?>("ApprenticeId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FGCharacterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WarbandId")
                        .HasColumnType("int");

                    b.Property<int?>("WizardId")
                        .HasColumnType("int");

                    b.HasKey("FGItemId");

                    b.HasIndex("ApprenticeId");

                    b.HasIndex("FGCharacterId");

                    b.HasIndex("WarbandId");

                    b.HasIndex("WizardId");

                    b.ToTable("FGItems");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Homebase", b =>
                {
                    b.Property<int>("HomebaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomebaseId"), 1L, 1);

                    b.Property<string>("BaseDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BaseTypeHomebaseTypeId")
                        .HasColumnType("int");

                    b.HasKey("HomebaseId");

                    b.HasIndex("BaseTypeHomebaseTypeId");

                    b.ToTable("Homebases");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.HomebaseType", b =>
                {
                    b.Property<int>("HomebaseTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomebaseTypeId"), 1L, 1);

                    b.Property<string>("BaseTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BaseTypePower")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HomebaseTypeId");

                    b.ToTable("HomebaseTypes");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Spell", b =>
                {
                    b.Property<int>("SpellId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpellId"), 1L, 1);

                    b.Property<int>("CastingNumber")
                        .HasColumnType("int");

                    b.Property<string>("SpellDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpellName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpellSchoolId")
                        .HasColumnType("int");

                    b.Property<string>("SpellType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WizardId")
                        .HasColumnType("int");

                    b.HasKey("SpellId");

                    b.HasIndex("SpellSchoolId");

                    b.HasIndex("WizardId");

                    b.ToTable("Spells");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.SpellSchool", b =>
                {
                    b.Property<int>("SpellSchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpellSchoolId"), 1L, 1);

                    b.Property<string>("SpellSchoolDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpellSchoolName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpellSchoolId");

                    b.ToTable("SpellSchools");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Warband", b =>
                {
                    b.Property<int>("WarbandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WarbandId"), 1L, 1);

                    b.Property<int>("ApprenticeFGCharacterId")
                        .HasColumnType("int");

                    b.Property<int?>("HomebaseId")
                        .HasColumnType("int");

                    b.Property<int>("Treasury")
                        .HasColumnType("int");

                    b.Property<string>("WarbandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WizardId")
                        .HasColumnType("int");

                    b.HasKey("WarbandId");

                    b.HasIndex("ApprenticeFGCharacterId");

                    b.HasIndex("HomebaseId");

                    b.HasIndex("WizardId");

                    b.ToTable("Warbands");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Wizard", b =>
                {
                    b.Property<int>("WizardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WizardId"), 1L, 1);

                    b.Property<int>("Armour")
                        .HasColumnType("int");

                    b.Property<string>("Backstory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("Fight")
                        .HasColumnType("int");

                    b.Property<bool>("IsWizard")
                        .HasColumnType("bit");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("MaxHealth")
                        .HasColumnType("int");

                    b.Property<int>("Move")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolSpellSchoolId")
                        .HasColumnType("int");

                    b.Property<int>("Shoot")
                        .HasColumnType("int");

                    b.Property<int>("TypeFGCharacterTypeID")
                        .HasColumnType("int");

                    b.Property<int>("Will")
                        .HasColumnType("int");

                    b.HasKey("WizardId");

                    b.HasIndex("SchoolSpellSchoolId");

                    b.HasIndex("TypeFGCharacterTypeID");

                    b.ToTable("Wizards");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Apprentice", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacterType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeFGCharacterTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Wizard", "Wizard")
                        .WithMany()
                        .HasForeignKey("WizardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Type");

                    b.Navigation("Wizard");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacter", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacterType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeFGCharacterTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Warband", null)
                        .WithMany("Soldiers")
                        .HasForeignKey("WarbandId");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacterType", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacterSuperType", "FGCharacterSuperType")
                        .WithMany("MyProperty")
                        .HasForeignKey("FGCharacterSuperTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FGCharacterSuperType");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGInjury", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Apprentice", null)
                        .WithMany("Injuries")
                        .HasForeignKey("ApprenticeId");

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacter", null)
                        .WithMany("Injuries")
                        .HasForeignKey("FGCharacterId");

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Wizard", null)
                        .WithMany("Injuries")
                        .HasForeignKey("WizardId");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGItem", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Apprentice", null)
                        .WithMany("Items")
                        .HasForeignKey("ApprenticeId");

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacter", null)
                        .WithMany("Items")
                        .HasForeignKey("FGCharacterId");

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Warband", null)
                        .WithMany("Vault")
                        .HasForeignKey("WarbandId");

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Wizard", null)
                        .WithMany("Items")
                        .HasForeignKey("WizardId");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Homebase", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.HomebaseType", "BaseType")
                        .WithMany()
                        .HasForeignKey("BaseTypeHomebaseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaseType");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Spell", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.SpellSchool", "SpellSchool")
                        .WithMany("Spells")
                        .HasForeignKey("SpellSchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Wizard", null)
                        .WithMany("KnownSpells")
                        .HasForeignKey("WizardId");

                    b.Navigation("SpellSchool");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Warband", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacter", "Apprentice")
                        .WithMany()
                        .HasForeignKey("ApprenticeFGCharacterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Homebase", "Homebase")
                        .WithMany()
                        .HasForeignKey("HomebaseId");

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.Wizard", "Wizard")
                        .WithMany()
                        .HasForeignKey("WizardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Apprentice");

                    b.Navigation("Homebase");

                    b.Navigation("Wizard");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Wizard", b =>
                {
                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.SpellSchool", "School")
                        .WithMany()
                        .HasForeignKey("SchoolSpellSchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraveTracker.Areas.Frostgrave.Models.FGCharacterType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeFGCharacterTypeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Apprentice", b =>
                {
                    b.Navigation("Injuries");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacter", b =>
                {
                    b.Navigation("Injuries");

                    b.Navigation("Items");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.FGCharacterSuperType", b =>
                {
                    b.Navigation("MyProperty");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.SpellSchool", b =>
                {
                    b.Navigation("Spells");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Warband", b =>
                {
                    b.Navigation("Soldiers");

                    b.Navigation("Vault");
                });

            modelBuilder.Entity("GraveTracker.Areas.Frostgrave.Models.Wizard", b =>
                {
                    b.Navigation("Injuries");

                    b.Navigation("Items");

                    b.Navigation("KnownSpells");
                });
#pragma warning restore 612, 618
        }
    }
}
