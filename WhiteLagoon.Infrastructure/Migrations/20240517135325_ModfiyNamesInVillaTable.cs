using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModfiyNamesInVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdatedData",
                table: "Villas",
                newName: "Updated_Data");

            migrationBuilder.RenameColumn(
                name: "CreatedData",
                table: "Villas",
                newName: "Created_Data");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Updated_Data",
                table: "Villas",
                newName: "UpdatedData");

            migrationBuilder.RenameColumn(
                name: "Created_Data",
                table: "Villas",
                newName: "CreatedData");
        }
    }
}
