using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Persistence.Migrations
{
    public partial class changeColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "_compatibleSockets",
                table: "Coolers",
                newName: "CompatibleSockets");

            migrationBuilder.RenameColumn(
                name: "_motherBoardFormFactor",
                table: "Cases",
                newName: "MotherBoardFormFactor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CompatibleSockets",
                table: "Coolers",
                newName: "_compatibleSockets");

            migrationBuilder.RenameColumn(
                name: "MotherBoardFormFactor",
                table: "Cases",
                newName: "_motherBoardFormFactor");
        }
    }
}
