using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraveTracker.Migrations
{
    public partial class WarbandUpdates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warbands_Wizards_WizardId",
                table: "Warbands");

            migrationBuilder.AlterColumn<int>(
                name: "WizardId",
                table: "Warbands",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WarbandDescription",
                table: "Warbands",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Warbands_Wizards_WizardId",
                table: "Warbands",
                column: "WizardId",
                principalTable: "Wizards",
                principalColumn: "WizardId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Warbands_Wizards_WizardId",
                table: "Warbands");

            migrationBuilder.DropColumn(
                name: "WarbandDescription",
                table: "Warbands");

            migrationBuilder.AlterColumn<int>(
                name: "WizardId",
                table: "Warbands",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Warbands_Wizards_WizardId",
                table: "Warbands",
                column: "WizardId",
                principalTable: "Wizards",
                principalColumn: "WizardId");
        }
    }
}
