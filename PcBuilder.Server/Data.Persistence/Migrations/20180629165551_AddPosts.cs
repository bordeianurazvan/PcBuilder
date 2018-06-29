using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Persistence.Migrations
{
    public partial class AddPosts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    CaseId = table.Column<Guid>(nullable: false),
                    CpuId = table.Column<Guid>(nullable: false),
                    CoolerId = table.Column<Guid>(nullable: true),
                    MotherboardId = table.Column<Guid>(nullable: false),
                    RamId = table.Column<Guid>(nullable: false),
                    VideoCardId = table.Column<Guid>(nullable: false),
                    StorageId = table.Column<Guid>(nullable: false),
                    PowerSupplyId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
