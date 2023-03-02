using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraveTracker.Migrations
{
    public partial class ItemsManyToManyUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FGArmours_Apprentices_ApprenticeId",
                table: "FGArmours");

            migrationBuilder.DropForeignKey(
                name: "FK_FGArmours_Wizards_WizardId",
                table: "FGArmours");

            migrationBuilder.DropForeignKey(
                name: "FK_FGItems_Apprentices_ApprenticeId",
                table: "FGItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FGItems_FGCharacterTypes_FGCharacterTypeID",
                table: "FGItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FGItems_Wizards_WizardId",
                table: "FGItems");

            migrationBuilder.DropForeignKey(
                name: "FK_FGWeapons_Apprentices_ApprenticeId",
                table: "FGWeapons");

            migrationBuilder.DropForeignKey(
                name: "FK_FGWeapons_Wizards_WizardId",
                table: "FGWeapons");

            migrationBuilder.DropIndex(
                name: "IX_FGWeapons_ApprenticeId",
                table: "FGWeapons");

            migrationBuilder.DropIndex(
                name: "IX_FGWeapons_WizardId",
                table: "FGWeapons");

            migrationBuilder.DropIndex(
                name: "IX_FGItems_ApprenticeId",
                table: "FGItems");

            migrationBuilder.DropIndex(
                name: "IX_FGItems_FGCharacterTypeID",
                table: "FGItems");

            migrationBuilder.DropIndex(
                name: "IX_FGItems_WizardId",
                table: "FGItems");

            migrationBuilder.DropIndex(
                name: "IX_FGArmours_ApprenticeId",
                table: "FGArmours");

            migrationBuilder.DropIndex(
                name: "IX_FGArmours_WizardId",
                table: "FGArmours");

            migrationBuilder.DropColumn(
                name: "ApprenticeId",
                table: "FGWeapons");

            migrationBuilder.DropColumn(
                name: "WizardId",
                table: "FGWeapons");

            migrationBuilder.DropColumn(
                name: "ApprenticeId",
                table: "FGItems");

            migrationBuilder.DropColumn(
                name: "FGCharacterTypeID",
                table: "FGItems");

            migrationBuilder.DropColumn(
                name: "WizardId",
                table: "FGItems");

            migrationBuilder.DropColumn(
                name: "ApprenticeId",
                table: "FGArmours");

            migrationBuilder.DropColumn(
                name: "WizardId",
                table: "FGArmours");

            migrationBuilder.AddColumn<int>(
                name: "SoldierId",
                table: "FGInjuries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FGArmourID",
                table: "FGCharacterTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FGWeaponID",
                table: "FGCharacterTypes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ApprenticeFGArmour",
                columns: table => new
                {
                    ApprenticesApprenticeId = table.Column<int>(type: "int", nullable: false),
                    ArmoursID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprenticeFGArmour", x => new { x.ApprenticesApprenticeId, x.ArmoursID });
                    table.ForeignKey(
                        name: "FK_ApprenticeFGArmour_Apprentices_ApprenticesApprenticeId",
                        column: x => x.ApprenticesApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApprenticeFGArmour_FGArmours_ArmoursID",
                        column: x => x.ArmoursID,
                        principalTable: "FGArmours",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprenticeFGItem",
                columns: table => new
                {
                    ApprenticesApprenticeId = table.Column<int>(type: "int", nullable: false),
                    ItemsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprenticeFGItem", x => new { x.ApprenticesApprenticeId, x.ItemsID });
                    table.ForeignKey(
                        name: "FK_ApprenticeFGItem_Apprentices_ApprenticesApprenticeId",
                        column: x => x.ApprenticesApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApprenticeFGItem_FGItems_ItemsID",
                        column: x => x.ItemsID,
                        principalTable: "FGItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprenticeFGWeapon",
                columns: table => new
                {
                    ApprenticesApprenticeId = table.Column<int>(type: "int", nullable: false),
                    WeaponsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprenticeFGWeapon", x => new { x.ApprenticesApprenticeId, x.WeaponsID });
                    table.ForeignKey(
                        name: "FK_ApprenticeFGWeapon_Apprentices_ApprenticesApprenticeId",
                        column: x => x.ApprenticesApprenticeId,
                        principalTable: "Apprentices",
                        principalColumn: "ApprenticeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApprenticeFGWeapon_FGWeapons_WeaponsID",
                        column: x => x.WeaponsID,
                        principalTable: "FGWeapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGArmourWizard",
                columns: table => new
                {
                    ArmoursID = table.Column<int>(type: "int", nullable: false),
                    WizardsWizardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGArmourWizard", x => new { x.ArmoursID, x.WizardsWizardId });
                    table.ForeignKey(
                        name: "FK_FGArmourWizard_FGArmours_ArmoursID",
                        column: x => x.ArmoursID,
                        principalTable: "FGArmours",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGArmourWizard_Wizards_WizardsWizardId",
                        column: x => x.WizardsWizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGCharacterTypeFGItem",
                columns: table => new
                {
                    BaseItemsID = table.Column<int>(type: "int", nullable: false),
                    CharacterTypesFGCharacterTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGCharacterTypeFGItem", x => new { x.BaseItemsID, x.CharacterTypesFGCharacterTypeID });
                    table.ForeignKey(
                        name: "FK_FGCharacterTypeFGItem_FGCharacterTypes_CharacterTypesFGCharacterTypeID",
                        column: x => x.CharacterTypesFGCharacterTypeID,
                        principalTable: "FGCharacterTypes",
                        principalColumn: "FGCharacterTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGCharacterTypeFGItem_FGItems_BaseItemsID",
                        column: x => x.BaseItemsID,
                        principalTable: "FGItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGItemWizard",
                columns: table => new
                {
                    ItemsID = table.Column<int>(type: "int", nullable: false),
                    WizardsWizardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGItemWizard", x => new { x.ItemsID, x.WizardsWizardId });
                    table.ForeignKey(
                        name: "FK_FGItemWizard_FGItems_ItemsID",
                        column: x => x.ItemsID,
                        principalTable: "FGItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGItemWizard_Wizards_WizardsWizardId",
                        column: x => x.WizardsWizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGWeaponWizard",
                columns: table => new
                {
                    WeaponsID = table.Column<int>(type: "int", nullable: false),
                    WizardsWizardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGWeaponWizard", x => new { x.WeaponsID, x.WizardsWizardId });
                    table.ForeignKey(
                        name: "FK_FGWeaponWizard_FGWeapons_WeaponsID",
                        column: x => x.WeaponsID,
                        principalTable: "FGWeapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGWeaponWizard_Wizards_WizardsWizardId",
                        column: x => x.WizardsWizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Soldier",
                columns: table => new
                {
                    SoldierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    characterTypeFGCharacterTypeID = table.Column<int>(type: "int", nullable: false),
                    Ability = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Soldier", x => x.SoldierId);
                    table.ForeignKey(
                        name: "FK_Soldier_FGCharacterTypes_characterTypeFGCharacterTypeID",
                        column: x => x.characterTypeFGCharacterTypeID,
                        principalTable: "FGCharacterTypes",
                        principalColumn: "FGCharacterTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGArmourSoldier",
                columns: table => new
                {
                    ArmoursID = table.Column<int>(type: "int", nullable: false),
                    SoldiersSoldierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGArmourSoldier", x => new { x.ArmoursID, x.SoldiersSoldierId });
                    table.ForeignKey(
                        name: "FK_FGArmourSoldier_FGArmours_ArmoursID",
                        column: x => x.ArmoursID,
                        principalTable: "FGArmours",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGArmourSoldier_Soldier_SoldiersSoldierId",
                        column: x => x.SoldiersSoldierId,
                        principalTable: "Soldier",
                        principalColumn: "SoldierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGItemSoldier",
                columns: table => new
                {
                    ItemsID = table.Column<int>(type: "int", nullable: false),
                    SoldiersSoldierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGItemSoldier", x => new { x.ItemsID, x.SoldiersSoldierId });
                    table.ForeignKey(
                        name: "FK_FGItemSoldier_FGItems_ItemsID",
                        column: x => x.ItemsID,
                        principalTable: "FGItems",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGItemSoldier_Soldier_SoldiersSoldierId",
                        column: x => x.SoldiersSoldierId,
                        principalTable: "Soldier",
                        principalColumn: "SoldierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FGWeaponSoldier",
                columns: table => new
                {
                    SoldiersSoldierId = table.Column<int>(type: "int", nullable: false),
                    WeaponsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FGWeaponSoldier", x => new { x.SoldiersSoldierId, x.WeaponsID });
                    table.ForeignKey(
                        name: "FK_FGWeaponSoldier_FGWeapons_WeaponsID",
                        column: x => x.WeaponsID,
                        principalTable: "FGWeapons",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FGWeaponSoldier_Soldier_SoldiersSoldierId",
                        column: x => x.SoldiersSoldierId,
                        principalTable: "Soldier",
                        principalColumn: "SoldierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FGInjuries_SoldierId",
                table: "FGInjuries",
                column: "SoldierId");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacterTypes_FGArmourID",
                table: "FGCharacterTypes",
                column: "FGArmourID");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacterTypes_FGWeaponID",
                table: "FGCharacterTypes",
                column: "FGWeaponID");

            migrationBuilder.CreateIndex(
                name: "IX_ApprenticeFGArmour_ArmoursID",
                table: "ApprenticeFGArmour",
                column: "ArmoursID");

            migrationBuilder.CreateIndex(
                name: "IX_ApprenticeFGItem_ItemsID",
                table: "ApprenticeFGItem",
                column: "ItemsID");

            migrationBuilder.CreateIndex(
                name: "IX_ApprenticeFGWeapon_WeaponsID",
                table: "ApprenticeFGWeapon",
                column: "WeaponsID");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmourSoldier_SoldiersSoldierId",
                table: "FGArmourSoldier",
                column: "SoldiersSoldierId");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmourWizard_WizardsWizardId",
                table: "FGArmourWizard",
                column: "WizardsWizardId");

            migrationBuilder.CreateIndex(
                name: "IX_FGCharacterTypeFGItem_CharacterTypesFGCharacterTypeID",
                table: "FGCharacterTypeFGItem",
                column: "CharacterTypesFGCharacterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FGItemSoldier_SoldiersSoldierId",
                table: "FGItemSoldier",
                column: "SoldiersSoldierId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItemWizard_WizardsWizardId",
                table: "FGItemWizard",
                column: "WizardsWizardId");

            migrationBuilder.CreateIndex(
                name: "IX_FGWeaponSoldier_WeaponsID",
                table: "FGWeaponSoldier",
                column: "WeaponsID");

            migrationBuilder.CreateIndex(
                name: "IX_FGWeaponWizard_WizardsWizardId",
                table: "FGWeaponWizard",
                column: "WizardsWizardId");

            migrationBuilder.CreateIndex(
                name: "IX_Soldier_characterTypeFGCharacterTypeID",
                table: "Soldier",
                column: "characterTypeFGCharacterTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_FGCharacterTypes_FGArmours_FGArmourID",
                table: "FGCharacterTypes",
                column: "FGArmourID",
                principalTable: "FGArmours",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FGCharacterTypes_FGWeapons_FGWeaponID",
                table: "FGCharacterTypes",
                column: "FGWeaponID",
                principalTable: "FGWeapons",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_FGInjuries_Soldier_SoldierId",
                table: "FGInjuries",
                column: "SoldierId",
                principalTable: "Soldier",
                principalColumn: "SoldierId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FGCharacterTypes_FGArmours_FGArmourID",
                table: "FGCharacterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_FGCharacterTypes_FGWeapons_FGWeaponID",
                table: "FGCharacterTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_FGInjuries_Soldier_SoldierId",
                table: "FGInjuries");

            migrationBuilder.DropTable(
                name: "ApprenticeFGArmour");

            migrationBuilder.DropTable(
                name: "ApprenticeFGItem");

            migrationBuilder.DropTable(
                name: "ApprenticeFGWeapon");

            migrationBuilder.DropTable(
                name: "FGArmourSoldier");

            migrationBuilder.DropTable(
                name: "FGArmourWizard");

            migrationBuilder.DropTable(
                name: "FGCharacterTypeFGItem");

            migrationBuilder.DropTable(
                name: "FGItemSoldier");

            migrationBuilder.DropTable(
                name: "FGItemWizard");

            migrationBuilder.DropTable(
                name: "FGWeaponSoldier");

            migrationBuilder.DropTable(
                name: "FGWeaponWizard");

            migrationBuilder.DropTable(
                name: "Soldier");

            migrationBuilder.DropIndex(
                name: "IX_FGInjuries_SoldierId",
                table: "FGInjuries");

            migrationBuilder.DropIndex(
                name: "IX_FGCharacterTypes_FGArmourID",
                table: "FGCharacterTypes");

            migrationBuilder.DropIndex(
                name: "IX_FGCharacterTypes_FGWeaponID",
                table: "FGCharacterTypes");

            migrationBuilder.DropColumn(
                name: "SoldierId",
                table: "FGInjuries");

            migrationBuilder.DropColumn(
                name: "FGArmourID",
                table: "FGCharacterTypes");

            migrationBuilder.DropColumn(
                name: "FGWeaponID",
                table: "FGCharacterTypes");

            migrationBuilder.AddColumn<int>(
                name: "ApprenticeId",
                table: "FGWeapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WizardId",
                table: "FGWeapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprenticeId",
                table: "FGItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FGCharacterTypeID",
                table: "FGItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WizardId",
                table: "FGItems",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApprenticeId",
                table: "FGArmours",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WizardId",
                table: "FGArmours",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_FGWeapons_ApprenticeId",
                table: "FGWeapons",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGWeapons_WizardId",
                table: "FGWeapons",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_ApprenticeId",
                table: "FGItems",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_FGCharacterTypeID",
                table: "FGItems",
                column: "FGCharacterTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_FGItems_WizardId",
                table: "FGItems",
                column: "WizardId");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmours_ApprenticeId",
                table: "FGArmours",
                column: "ApprenticeId");

            migrationBuilder.CreateIndex(
                name: "IX_FGArmours_WizardId",
                table: "FGArmours",
                column: "WizardId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGArmours_Apprentices_ApprenticeId",
                table: "FGArmours",
                column: "ApprenticeId",
                principalTable: "Apprentices",
                principalColumn: "ApprenticeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGArmours_Wizards_WizardId",
                table: "FGArmours",
                column: "WizardId",
                principalTable: "Wizards",
                principalColumn: "WizardId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItems_Apprentices_ApprenticeId",
                table: "FGItems",
                column: "ApprenticeId",
                principalTable: "Apprentices",
                principalColumn: "ApprenticeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItems_FGCharacterTypes_FGCharacterTypeID",
                table: "FGItems",
                column: "FGCharacterTypeID",
                principalTable: "FGCharacterTypes",
                principalColumn: "FGCharacterTypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_FGItems_Wizards_WizardId",
                table: "FGItems",
                column: "WizardId",
                principalTable: "Wizards",
                principalColumn: "WizardId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGWeapons_Apprentices_ApprenticeId",
                table: "FGWeapons",
                column: "ApprenticeId",
                principalTable: "Apprentices",
                principalColumn: "ApprenticeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FGWeapons_Wizards_WizardId",
                table: "FGWeapons",
                column: "WizardId",
                principalTable: "Wizards",
                principalColumn: "WizardId");
        }
    }
}
