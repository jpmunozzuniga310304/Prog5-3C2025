using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prog5_3C2025.Migrations
{
    /// <inheritdoc />
    public partial class Enfermedades : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Enfermedades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Enfermedad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creada = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enfermedades", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enfermedades");
        }
    }
}
