using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestion_voiture_BackOffice.Migrations
{
    /// <inheritdoc />
    public partial class CreatTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Vehicle");

            migrationBuilder.AddColumn<int>(
                name: "typeVehicleId",
                table: "Vehicle",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypeVehicle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeVehicle", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_typeVehicleId",
                table: "Vehicle",
                column: "typeVehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_TypeVehicle_typeVehicleId",
                table: "Vehicle",
                column: "typeVehicleId",
                principalTable: "TypeVehicle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_TypeVehicle_typeVehicleId",
                table: "Vehicle");

            migrationBuilder.DropTable(
                name: "TypeVehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_typeVehicleId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "typeVehicleId",
                table: "Vehicle");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Vehicle",
                type: "nvarchar(5)",
                maxLength: 5,
                nullable: false,
                defaultValue: "");
        }
    }
}
