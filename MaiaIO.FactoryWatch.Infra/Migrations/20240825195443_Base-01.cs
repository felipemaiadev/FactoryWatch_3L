using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaiaIO.FactoryWatch.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Base01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProcessLines",
                columns: table => new
                {
                    lineCode = table.Column<int>(type: "int", nullable: false),
                    lineSeq = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastMaintence = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastMainteceCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessLines", x => new { x.lineCode, x.lineSeq });
                });

            migrationBuilder.CreateTable(
                name: "Machines",
                columns: table => new
                {
                    codeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastMaintece = table.Column<DateTime>(type: "datetime2", nullable: false),
                    lastMainteceCode = table.Column<int>(type: "int", nullable: false),
                    ProcessLinelineCode = table.Column<int>(type: "int", nullable: true),
                    ProcessLinelineSeq = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Machines", x => x.codeId);
                    table.ForeignKey(
                        name: "FK_Machines_ProcessLines_ProcessLinelineCode_ProcessLinelineSeq",
                        columns: x => new { x.ProcessLinelineCode, x.ProcessLinelineSeq },
                        principalTable: "ProcessLines",
                        principalColumns: new[] { "lineCode", "lineSeq" });
                });

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    vendor = table.Column<int>(type: "int", nullable: false),
                    codeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    device = table.Column<int>(type: "int", nullable: false),
                    installStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MachinecodeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => new { x.vendor, x.codeId });
                    table.ForeignKey(
                        name: "FK_Devices_Machines_MachinecodeId",
                        column: x => x.MachinecodeId,
                        principalTable: "Machines",
                        principalColumn: "codeId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_MachinecodeId",
                table: "Devices",
                column: "MachinecodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_ProcessLinelineCode_ProcessLinelineSeq",
                table: "Machines",
                columns: new[] { "ProcessLinelineCode", "ProcessLinelineSeq" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropTable(
                name: "Machines");

            migrationBuilder.DropTable(
                name: "ProcessLines");
        }
    }
}
