using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraveTracker.Migrations
{
    public partial class ItemsOverhaul : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "FGCharacterTypes");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "FGItems",
                newName: "Notes");

            migrationBuilder.RenameColumn(
                name: "FGItemId",
                table: "FGItems",
                newName: "ID");

            migrationBuilder.AddColumn<int>(
                name: "FGCharacterTypeID",
                table: "FGItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FGArmours",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmourMod = table.Column<int>(type: "int", nullable: false),
                    ApprenticeId = table.Column<int>(type: "int", nullable: true),
                    FGCharacterId = table.Column<int>(type: "int", nullable: true),
                    WizardId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGArmours", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FGArmours_Apprentices_ApprenticeId",
                        column: x => x.ApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId");
                    table.ForeignKey(
                        name: "FK_FGArmours_FGCharacters_FGCharacterId",
                        column: x => x.FGCharacterId,
                        principalTable: "FGCharacters",
                        principalColumn: "FGCharacterId");
                    table.ForeignKey(
                        name: "FK_FGArmours_Wizards_WizardId",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId");
                });

            migrationBuilder.CreateTable(
                name: "FGWeapons",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageMod = table.Column<int>(type: "int", nullable: false),
                    Range = table.Column<int>(type: "int", nullable: false),
                    ApprenticeId = table.Column<int>(type: "int", nullable: true),
                    FGCharacterId = table.Column<int>(type: "int", nullable: true),
                    WizardId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGWeapons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FGWeapons_Apprentices_ApprenticeId",
                        column: x => x.ApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId");
                    table.ForeignKey(
                        name: "FK_FGWeapons_FGCharacters_FGCharacterId",
                        column: x => x.FGCharacterId,
                        principalTable: "FGCharacters",
                        principalColumn: "FGCharacterId");
                    table.ForeignKey(
                        name: "FK_FGWeapons_Wizards_WizardId",
                        column: x => x.WizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_FGCharacterTypeID",
                table: "FGItems",
                column: "FGCharacterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmours_ApprenticeId",
                table: "FGArmours",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmours_FGCharacterId",
                table: "FGArmours",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmours_WizardId",
                table: "FGArmours",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "IX_FGWeapons_ApprenticeId",
                table: "FGWeapons",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGWeapons_FGCharacterId",
                table: "FGWeapons",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGWeapons_WizardId",
                table: "FGWeapons",
                column: "WizardId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItems_FGCharacterTypes_FGCharacterTypeID",
                table: "FGItems",
                column: "FGCharacterTypeID",
                principalTable: "FGCharacterTypes",
                principalColumn: "FGCharacterTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FGItems_FGCharacterTypes_FGCharacterTypeID",
                table: "FGItems");

            migrationBuilder.DropTable(
                name: "FGArmours");

            migrationBuilder.DropTable(
                name: "FGWeapons");

            migrationBuilder.DropIndex(
                name: "IX_FGItems_FGCharacterTypeID",
                table: "FGItems");

            migrationBuilder.DropColumn(
                name: "FGCharacterTypeID",
                table: "FGItems");

            migrationBuilder.RenameColumn(
                name: "Notes",
                table: "FGItems",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FGItems",
                newName: "FGItemId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "FGCharacterTypes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
