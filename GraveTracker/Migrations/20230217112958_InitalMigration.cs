using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraveTracker.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apprentices",
                columns: table => new
                {
                    ApprenticeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Move = table.Column<int>(type: "int", nullable: false),
                    Fight = table.Column<int>(type: "int", nullable: false),
                    Shoot = table.Column<int>(type: "int", nullable: false),
                    Armour = table.Column<int>(type: "int", nullable: false),
                    Will = table.Column<int>(type: "int", nullable: false),
                    MaxHealth = table.Column<int>(type: "int", nullable: false),
                    Backstory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apprentices", x => x.ApprenticeId);
                });

            migrationBuilder.CreateTable(
                name: "FGCharacterSuperTypes",
                columns: table => new
                {
                    FGCharacterSuperTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FGCharacterSuperTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGCharacterSuperTypes", x => x.FGCharacterSuperTypeId);
                });

            migrationBuilder.CreateTable(
                name: "HomebaseTypes",
                columns: table => new
                {
                    HomebaseTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseTypePower = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomebaseTypes", x => x.HomebaseTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SpellSchools",
                columns: table => new
                {
                    SpellSchoolId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellSchoolName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellSchoolDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellSchools", x => x.SpellSchoolId);
                });

            migrationBuilder.CreateTable(
                name: "FGCharacterTypes",
                columns: table => new
                {
                    FGCharacterTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseMove = table.Column<int>(type: "int", nullable: false),
                    BaseFight = table.Column<int>(type: "int", nullable: false),
                    BaseShoot = table.Column<int>(type: "int", nullable: false),
                    BaseArmour = table.Column<int>(type: "int", nullable: false),
                    BaseWill = table.Column<int>(type: "int", nullable: false),
                    BaseMaxHealth = table.Column<int>(type: "int", nullable: false),
                    FGCharacterSuperTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGCharacterTypes", x => x.FGCharacterTypeID);
                    table.ForeignKey(
                        name: "FK_FGCharacterTypes_FGCharacterSuperTypes_FGCharacterSuperTypeId",
                        column: x => x.FGCharacterSuperTypeId,
                        principalTable: "FGCharacterSuperTypes",
                        principalColumn: "FGCharacterSuperTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Homebases",
                columns: table => new
                {
                    HomebaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseTypeHomebaseTypeId = table.Column<int>(type: "int", nullable: false),
                    BaseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Homebases", x => x.HomebaseId);
                    table.ForeignKey(
                        name: "FK_Homebases_HomebaseTypes_BaseTypeHomebaseTypeId",
                        column: x => x.BaseTypeHomebaseTypeId,
                        principalTable: "HomebaseTypes",
                        principalColumn: "HomebaseTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    SpellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CastingNumber = table.Column<int>(type: "int", nullable: false),
                    SpellDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpellSchoolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.SpellId);
                    table.ForeignKey(
                        name: "FK_Spells_SpellSchools_SpellSchoolId",
                        column: x => x.SpellSchoolId,
                        principalTable: "SpellSchools",
                        principalColumn: "SpellSchoolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wizards",
                columns: table => new
                {
                    WizardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    SpellSchoolId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Move = table.Column<int>(type: "int", nullable: false),
                    Fight = table.Column<int>(type: "int", nullable: false),
                    Shoot = table.Column<int>(type: "int", nullable: false),
                    Armour = table.Column<int>(type: "int", nullable: false),
                    Will = table.Column<int>(type: "int", nullable: false),
                    MaxHealth = table.Column<int>(type: "int", nullable: false),
                    Backstory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wizards", x => x.WizardId);
                    table.ForeignKey(
                        name: "FK_Wizards_SpellSchools_SpellSchoolId",
                        column: x => x.SpellSchoolId,
                        principalTable: "SpellSchools",
                        principalColumn: "SpellSchoolId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Warbands",
                columns: table => new
                {
                    WarbandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarbandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WizardId = table.Column<int>(type: "int", nullable: true),
                    ApprenticeId = table.Column<int>(type: "int", nullable: true),
                    HomebaseId = table.Column<int>(type: "int", nullable: true),
                    Treasury = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warbands", x => x.WarbandId);
                    table.ForeignKey(
                        name: "FK_Warbands_Apprentices_ApprenticeId",
                        column: x => x.ApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId");
                    table.ForeignKey(
                        name: "FK_Warbands_Homebases_HomebaseId",
                        column: x => x.HomebaseId,
                        principalTable: "Homebases",
                        principalColumn: "HomebaseId");
                    table.ForeignKey(
                        name: "FK_Warbands_Wizards_WizardId",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId");
                });

            migrationBuilder.CreateTable(
                name: "FGCharacters",
                columns: table => new
                {
                    FGCharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeFGCharacterTypeID = table.Column<int>(type: "int", nullable: false),
                    WarbandId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Move = table.Column<int>(type: "int", nullable: false),
                    Fight = table.Column<int>(type: "int", nullable: false),
                    Shoot = table.Column<int>(type: "int", nullable: false),
                    Armour = table.Column<int>(type: "int", nullable: false),
                    Will = table.Column<int>(type: "int", nullable: false),
                    MaxHealth = table.Column<int>(type: "int", nullable: false),
                    Backstory = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGCharacters", x => x.FGCharacterId);
                    table.ForeignKey(
                        name: "FK_FGCharacters_FGCharacterTypes_TypeFGCharacterTypeID",
                        column: x => x.TypeFGCharacterTypeID,
                        principalTable: "FGCharacterTypes",
                        principalColumn: "FGCharacterTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGCharacters_Warbands_WarbandId",
                        column: x => x.WarbandId,
                        principalTable: "Warbands",
                        principalColumn: "WarbandId");
                });

            migrationBuilder.CreateTable(
                name: "FGInjuries",
                columns: table => new
                {
                    FGInjuryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InjuryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Effect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprenticeId = table.Column<int>(type: "int", nullable: true),
                    FGCharacterId = table.Column<int>(type: "int", nullable: true),
                    WizardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGInjuries", x => x.FGInjuryId);
                    table.ForeignKey(
                        name: "FK_FGInjuries_Apprentices_ApprenticeId",
                        column: x => x.ApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId");
                    table.ForeignKey(
                        name: "FK_FGInjuries_FGCharacters_FGCharacterId",
                        column: x => x.FGCharacterId,
                        principalTable: "FGCharacters",
                        principalColumn: "FGCharacterId");
                    table.ForeignKey(
                        name: "FK_FGInjuries_Wizards_WizardId",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId");
                });

            migrationBuilder.CreateTable(
                name: "FGItems",
                columns: table => new
                {
                    FGItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApprenticeId = table.Column<int>(type: "int", nullable: true),
                    FGCharacterId = table.Column<int>(type: "int", nullable: true),
                    WarbandId = table.Column<int>(type: "int", nullable: true),
                    WizardId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGItems", x => x.FGItemId);
                    table.ForeignKey(
                        name: "FK_FGItems_Apprentices_ApprenticeId",
                        column: x => x.ApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId");
                    table.ForeignKey(
                        name: "FK_FGItems_FGCharacters_FGCharacterId",
                        column: x => x.FGCharacterId,
                        principalTable: "FGCharacters",
                        principalColumn: "FGCharacterId");
                    table.ForeignKey(
                        name: "FK_FGItems_Warbands_WarbandId",
                        column: x => x.WarbandId,
                        principalTable: "Warbands",
                        principalColumn: "WarbandId");
                    table.ForeignKey(
                        name: "FK_FGItems_Wizards_WizardId",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacters_TypeFGCharacterTypeID",
                table: "FGCharacters",
                column: "TypeFGCharacterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacters_WarbandId",
                table: "FGCharacters",
                column: "WarbandId");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacterTypes_FGCharacterSuperTypeId",
                table: "FGCharacterTypes",
                column: "FGCharacterSuperTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGInjuries_ApprenticeId",
                table: "FGInjuries",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGInjuries_FGCharacterId",
                table: "FGInjuries",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGInjuries_WizardId",
                table: "FGInjuries",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_ApprenticeId",
                table: "FGItems",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_FGCharacterId",
                table: "FGItems",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_WarbandId",
                table: "FGItems",
                column: "WarbandId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_WizardId",
                table: "FGItems",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "IX_Homebases_BaseTypeHomebaseTypeId",
                table: "Homebases",
                column: "BaseTypeHomebaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Spells_SpellSchoolId",
                table: "Spells",
                column: "SpellSchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Warbands_ApprenticeId",
                table: "Warbands",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_Warbands_HomebaseId",
                table: "Warbands",
                column: "HomebaseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warbands_WizardId",
                table: "Warbands",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "IX_Wizards_SpellSchoolId",
                table: "Wizards",
                column: "SpellSchoolId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FGInjuries");

            migrationBuilder.DropTable(
                name: "FGItems");

            migrationBuilder.DropTable(
                name: "Spells");

            migrationBuilder.DropTable(
                name: "FGCharacters");

            migrationBuilder.DropTable(
                name: "FGCharacterTypes");

            migrationBuilder.DropTable(
                name: "Warbands");

            migrationBuilder.DropTable(
                name: "FGCharacterSuperTypes");

            migrationBuilder.DropTable(
                name: "Apprentices");

            migrationBuilder.DropTable(
                name: "Homebases");

            migrationBuilder.DropTable(
                name: "Wizards");

            migrationBuilder.DropTable(
                name: "HomebaseTypes");

            migrationBuilder.DropTable(
                name: "SpellSchools");
        }
    }
}
