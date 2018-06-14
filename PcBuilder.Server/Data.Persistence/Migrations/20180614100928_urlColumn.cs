using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Persistence.Migrations
{
    public partial class urlColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "VideoCards",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "WriteSpeed",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Rpm",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "ReadSpeed",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Capacity",
                table: "Storages",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Storages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Rams",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Power",
                table: "PowerSupplies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Efficiency",
                table: "PowerSupplies",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "PowerSupplies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Motherboards",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Cpus",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Noise",
                table: "Coolers",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "FanSpeed",
                table: "Coolers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Coolers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Cases",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "VideoCards");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Storages");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Rams");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "PowerSupplies");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Motherboards");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Cpus");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Coolers");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Cases");

            migrationBuilder.AlterColumn<double>(
                name: "WriteSpeed",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Rpm",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "ReadSpeed",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Capacity",
                table: "Storages",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Power",
                table: "PowerSupplies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Efficiency",
                table: "PowerSupplies",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Noise",
                table: "Coolers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FanSpeed",
                table: "Coolers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
