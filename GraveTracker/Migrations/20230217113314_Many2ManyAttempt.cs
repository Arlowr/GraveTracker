using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraveTracker.Migrations
{
    public partial class Many2ManyAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpellWizard",
                columns: table => new
                {
                    KnownSpellsSpellId = table.Column<int>(type: "int", nullable: false),
                    WizardsWizardId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpellWizard", x => new { x.KnownSpellsSpellId, x.WizardsWizardId });
                    table.ForeignKey(
                        name: "FK_SpellWizard_Spells_KnownSpellsSpellId",
                        column: x => x.KnownSpellsSpellId,
                        principalTable: "Spells",
                        principalColumn: "SpellId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SpellWizard_Wizards_WizardsWizardId",
                        column: x => x.WizardsWizardId,
                        principalTable: "Wizards",
                        principalColumn: "WizardId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SpellWizard_WizardsWizardId",
                table: "SpellWizard",
                column: "WizardsWizardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpellWizard");
        }
    }
}
