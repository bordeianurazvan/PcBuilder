using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Persistence.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cases",
                columns: table => new
                {
                    _motherBoardFormFactor = table.Column<string>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    NumberOfSlots = table.Column<int>(nullable: false),
                    CoolerHeight = table.Column<int>(nullable: false),
                    VideoCardWidth = table.Column<int>(nullable: false),
                    Fans = table.Column<int>(nullable: false),
                    TotalFans = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Coolers",
                columns: table => new
                {
                    _compatibleSockets = table.Column<string>(nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    HeatPipes = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Fans = table.Column<int>(nullable: false),
                    FanSize = table.Column<int>(nullable: false),
                    FanSpeed = table.Column<int>(nullable: false),
                    Noise = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coolers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cpus",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Socket = table.Column<string>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    Core = table.Column<string>(nullable: true),
                    Cores = table.Column<int>(nullable: false),
                    Threads = table.Column<int>(nullable: false),
                    BaseFrequency = table.Column<double>(nullable: false),
                    TurboFrequency = table.Column<double>(nullable: false),
                    Cache = table.Column<double>(nullable: false),
                    HasStockCooler = table.Column<bool>(nullable: false),
                    TypeOfRam = table.Column<string>(nullable: false),
                    MaximumRamMemory = table.Column<int>(nullable: false),
                    RamFrequency = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cpus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    FormFactor = table.Column<string>(nullable: false),
                    Socket = table.Column<string>(nullable: false),
                    Sata = table.Column<int>(nullable: false),
                    M2 = table.Column<int>(nullable: false),
                    Network = table.Column<string>(nullable: true),
                    TypeOfRam = table.Column<string>(nullable: false),
                    MaximumRamMemory = table.Column<double>(nullable: false),
                    RamFrequency = table.Column<double>(nullable: false),
                    RamSlots = table.Column<int>(nullable: false),
                    GraphicInterface = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplies",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Power = table.Column<int>(nullable: false),
                    Efficiency = table.Column<int>(nullable: false),
                    Certificate = table.Column<string>(nullable: true),
                    IsModular = table.Column<bool>(nullable: false),
                    Cooler = table.Column<string>(nullable: true),
                    Pfc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rams",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Type = table.Column<string>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Frequency = table.Column<double>(nullable: false),
                    Latency = table.Column<string>(nullable: true),
                    Standard = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    FormFactor = table.Column<string>(nullable: false),
                    Interface = table.Column<string>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    WriteSpeed = table.Column<double>(nullable: false),
                    ReadSpeed = table.Column<double>(nullable: false),
                    Rpm = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Price = table.Column<double>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: false),
                    Interface = table.Column<string>(nullable: false),
                    Resolution = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    MemorySize = table.Column<int>(nullable: false),
                    MemoryBus = table.Column<int>(nullable: false),
                    MemoryFrequency = table.Column<double>(nullable: false),
                    BaseFrequency = table.Column<double>(nullable: false),
                    GpuBoostClock = table.Column<double>(nullable: false),
                    Width = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cases");

            migrationBuilder.DropTable(
                name: "Coolers");

            migrationBuilder.DropTable(
                name: "Cpus");

            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PowerSupplies");

            migrationBuilder.DropTable(
                name: "Rams");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "VideoCards");
        }
    }
}
