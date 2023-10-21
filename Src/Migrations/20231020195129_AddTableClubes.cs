using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutScout_2023.Migrations
{
    public partial class AddTableClubes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clubes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Série = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gols2021 = table.Column<int>(type: "int", nullable: false),
                    gols2022 = table.Column<int>(type: "int", nullable: false),
                    gols2023 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clubes");
        }
    }
}
