using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraveTracker.Migrations
{
    public partial class ChangeCharacterToSoldier : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FGArmours_FGCharacters_FGCharacterId",
                table: "FGArmours");

            migrationBuilder.DropForeignKey(
                name: "FK_FGArmourSoldier_Soldier_SoldiersSoldierId",
                table: "FGArmourSoldier");

            migrationBuilder.DropForeignKey(
                name: "FK_FGInjuries_FGCharacters_FGCharacterId",
                table: "FGInjuries");

            migrationBuilder.DropForeignKey(
                name: "FK_FGInjuries_Soldier_SoldierId",
                table: "FGInjuries");

            migrationBuilder.DropForeignKey(
                name: "FK_FGItems_FGCharacters_FGCharacterId",
                table: "FGItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FGItemSoldier_Soldier_SoldiersSoldierId",
                table: "FGItemSoldier");

            migrationBuilder.DropForeignKey(
                name: "FK_FGWeapons_FGCharacters_FGCharacterId",
                table: "FGWeapons");

            migrationBuilder.DropForeignKey(
                name: "FK_FGWeaponSoldier_Soldier_SoldiersSoldierId",
                table: "FGWeaponSoldier");

            migrationBuilder.DropForeignKey(
                name: "FK_Soldier_FGCharacterTypes_characterTypeFGCharacterTypeID",
                table: "Soldier");

            migrationBuilder.DropTable(
                name: "FGCharacters");

            migrationBuilder.DropIndex(
                name: "IX_FGWeapons_FGCharacterId",
                table: "FGWeapons");

            migrationBuilder.DropIndex(
                name: "IX_FGItems_FGCharacterId",
                table: "FGItems");

            migrationBuilder.DropIndex(
                name: "IX_FGInjuries_FGCharacterId",
                table: "FGInjuries");

            migrationBuilder.DropIndex(
                name: "IX_FGArmours_FGCharacterId",
                table: "FGArmours");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Soldier",
                table: "Soldier");

            migrationBuilder.DropColumn(
                name: "FGCharacterId",
                table: "FGWeapons");

            migrationBuilder.DropColumn(
                name: "FGCharacterId",
                table: "FGItems");

            migrationBuilder.DropColumn(
                name: "FGCharacterId",
                table: "FGInjuries");

            migrationBuilder.DropColumn(
                name: "FGCharacterId",
                table: "FGArmours");

            migrationBuilder.RenameTable(
                name: "Soldier",
                newName: "Soldiers");

            migrationBuilder.RenameIndex(
                name: "IX_Soldier_characterTypeFGCharacterTypeID",
                table: "Soldiers",
                newName: "IX_Soldiers_characterTypeFGCharacterTypeID");

            migrationBuilder.AddColumn<int>(
                name: "WarbandId",
                table: "Soldiers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Soldiers",
                table: "Soldiers",
                column: "SoldierId");

            migrationBuilder.CreateIndex(
                name: "IX_Soldiers_WarbandId",
                table: "Soldiers",
                column: "WarbandId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGArmourSoldier_Soldiers_SoldiersSoldierId",
                table: "FGArmourSoldier",
                column: "SoldiersSoldierId",
                principalTable: "Soldiers",
                principalColumn: "SoldierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FGInjuries_Soldiers_SoldierId",
                table: "FGInjuries",
                column: "SoldierId",
                principalTable: "Soldiers",
                principalColumn: "SoldierId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItemSoldier_Soldiers_SoldiersSoldierId",
                table: "FGItemSoldier",
                column: "SoldiersSoldierId",
                principalTable: "Soldiers",
                principalColumn: "SoldierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FGWeaponSoldier_Soldiers_SoldiersSoldierId",
                table: "FGWeaponSoldier",
                column: "SoldiersSoldierId",
                principalTable: "Soldiers",
                principalColumn: "SoldierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Soldiers_FGCharacterTypes_characterTypeFGCharacterTypeID",
                table: "Soldiers",
                column: "characterTypeFGCharacterTypeID",
                principalTable: "FGCharacterTypes",
                principalColumn: "FGCharacterTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Soldiers_Warbands_WarbandId",
                table: "Soldiers",
                column: "WarbandId",
                principalTable: "Warbands",
                principalColumn: "WarbandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FGArmourSoldier_Soldiers_SoldiersSoldierId",
                table: "FGArmourSoldier");

            migrationBuilder.DropForeignKey(
                name: "FK_FGInjuries_Soldiers_SoldierId",
                table: "FGInjuries");

            migrationBuilder.DropForeignKey(
                name: "FK_FGItemSoldier_Soldiers_SoldiersSoldierId",
                table: "FGItemSoldier");

            migrationBuilder.DropForeignKey(
                name: "FK_FGWeaponSoldier_Soldiers_SoldiersSoldierId",
                table: "FGWeaponSoldier");

            migrationBuilder.DropForeignKey(
                name: "FK_Soldiers_FGCharacterTypes_characterTypeFGCharacterTypeID",
                table: "Soldiers");

            migrationBuilder.DropForeignKey(
                name: "FK_Soldiers_Warbands_WarbandId",
                table: "Soldiers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Soldiers",
                table: "Soldiers");

            migrationBuilder.DropIndex(
                name: "IX_Soldiers_WarbandId",
                table: "Soldiers");

            migrationBuilder.DropColumn(
                name: "WarbandId",
                table: "Soldiers");

            migrationBuilder.RenameTable(
                name: "Soldiers",
                newName: "Soldier");

            migrationBuilder.RenameIndex(
                name: "IX_Soldiers_characterTypeFGCharacterTypeID",
                table: "Soldier",
                newName: "IX_Soldier_characterTypeFGCharacterTypeID");

            migrationBuilder.AddColumn<int>(
                name: "FGCharacterId",
                table: "FGWeapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FGCharacterId",
                table: "FGItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FGCharacterId",
                table: "FGInjuries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FGCharacterId",
                table: "FGArmours",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Soldier",
                table: "Soldier",
                column: "SoldierId");

            migrationBuilder.CreateTable(
                name: "FGCharacters",
                columns: table => new
                {
                    FGCharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeFGCharacterTypeID = table.Column<int>(type: "int", nullable: false),
                    Armour = table.Column<int>(type: "int", nullable: false),
                    Backstory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fight = table.Column<int>(type: "int", nullable: false),
                    MaxHealth = table.Column<int>(type: "int", nullable: false),
                    Move = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shoot = table.Column<int>(type: "int", nullable: false),
                    WarbandId = table.Column<int>(type: "int", nullable: true),
                    Will = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_FGWeapons_FGCharacterId",
                table: "FGWeapons",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_FGCharacterId",
                table: "FGItems",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGInjuries_FGCharacterId",
                table: "FGInjuries",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmours_FGCharacterId",
                table: "FGArmours",
                column: "FGCharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacters_TypeFGCharacterTypeID",
                table: "FGCharacters",
                column: "TypeFGCharacterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacters_WarbandId",
                table: "FGCharacters",
                column: "WarbandId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGArmours_FGCharacters_FGCharacterId",
                table: "FGArmours",
                column: "FGCharacterId",
                principalTable: "FGCharacters",
                principalColumn: "FGCharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGArmourSoldier_Soldier_SoldiersSoldierId",
                table: "FGArmourSoldier",
                column: "SoldiersSoldierId",
                principalTable: "Soldier",
                principalColumn: "SoldierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FGInjuries_FGCharacters_FGCharacterId",
                table: "FGInjuries",
                column: "FGCharacterId",
                principalTable: "FGCharacters",
                principalColumn: "FGCharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGInjuries_Soldier_SoldierId",
                table: "FGInjuries",
                column: "SoldierId",
                principalTable: "Soldier",
                principalColumn: "SoldierId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItems_FGCharacters_FGCharacterId",
                table: "FGItems",
                column: "FGCharacterId",
                principalTable: "FGCharacters",
                principalColumn: "FGCharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItemSoldier_Soldier_SoldiersSoldierId",
                table: "FGItemSoldier",
                column: "SoldiersSoldierId",
                principalTable: "Soldier",
                principalColumn: "SoldierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FGWeapons_FGCharacters_FGCharacterId",
                table: "FGWeapons",
                column: "FGCharacterId",
                principalTable: "FGCharacters",
                principalColumn: "FGCharacterId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGWeaponSoldier_Soldier_SoldiersSoldierId",
                table: "FGWeaponSoldier",
                column: "SoldiersSoldierId",
                principalTable: "Soldier",
                principalColumn: "SoldierId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Soldier_FGCharacterTypes_characterTypeFGCharacterTypeID",
                table: "Soldier",
                column: "characterTypeFGCharacterTypeID",
                principalTable: "FGCharacterTypes",
                principalColumn: "FGCharacterTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
