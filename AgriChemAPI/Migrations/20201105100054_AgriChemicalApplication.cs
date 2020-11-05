using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AgriChemAPI.Migrations
{
    public partial class AgriChemicalApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgriChemicalApplication",
                columns: table => new
                {
                    AgriChemAppId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    FromTime = table.Column<TimeSpan>(nullable: false),
                    ToTime = table.Column<TimeSpan>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    Contractor = table.Column<string>(nullable: true),
                    ContractManager = table.Column<string>(nullable: true),
                    Comments = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Method = table.Column<string>(nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    ReasonComments = table.Column<string>(nullable: true),
                    AgriChemical1 = table.Column<string>(nullable: true),
                    AgriChemical1Volume = table.Column<string>(nullable: true),
                    AgriChemical1Unit = table.Column<string>(nullable: true),
                    AgriChemical2 = table.Column<string>(nullable: true),
                    AgriChemical2Volume = table.Column<string>(nullable: true),
                    AgriChemical2Unit = table.Column<string>(nullable: true),
                    AgriChemical3 = table.Column<string>(nullable: true),
                    AgriChemical3Volume = table.Column<string>(nullable: true),
                    AgriChemical3Unit = table.Column<string>(nullable: true),
                    PostComments = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriChemicalApplication", x => x.AgriChemAppId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgriChemicalApplication");
        }
    }
}
