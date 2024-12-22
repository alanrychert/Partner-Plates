using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PartnerPlatesBackend.Migrations
{
    /// <inheritdoc />
    public partial class RemoveForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Combos_Providers_providerId",
                table: "Combos");

            migrationBuilder.DropIndex(
                name: "IX_Combos_providerId",
                table: "Combos");

            migrationBuilder.DropColumn(
                name: "day",
                table: "Days");

            migrationBuilder.DropColumn(
                name: "providerId",
                table: "Combos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "day",
                table: "Days",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "providerId",
                table: "Combos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Combos_providerId",
                table: "Combos",
                column: "providerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Combos_Providers_providerId",
                table: "Combos",
                column: "providerId",
                principalTable: "Providers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
