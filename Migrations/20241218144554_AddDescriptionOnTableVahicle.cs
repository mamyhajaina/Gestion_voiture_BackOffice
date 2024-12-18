using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_voiture_BackOffice.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionOnTableVahicle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descriptions",
                table: "Vehicle",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptions",
                table: "Vehicle");
        }
    }
}
