using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace D20240408.AccesoADatos.Migrations
{
    public partial class Migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonasD",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApellidoD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaNacimientoD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SueldoD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstatusD = table.Column<byte>(type: "tinyint", nullable: false),
                    ComentarioD = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonasD", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonasD");
        }
    }
}
