using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLMKTest.Domain.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentDowntimes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    EquipmentName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DowntimeStart = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DownTimeEnd = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentDowntimes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentDowntimes");
        }
    }
}
