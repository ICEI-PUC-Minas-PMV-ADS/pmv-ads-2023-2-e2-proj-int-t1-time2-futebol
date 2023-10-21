using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FutScout_2023.Migrations
{
    public partial class AddTableAtacantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atacantes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Clube = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Partidas2023 = table.Column<int>(type: "int", nullable: false),
                    Gols2023 = table.Column<int>(type: "int", nullable: false),
                    Assists2023 = table.Column<int>(type: "int", nullable: false),
                    Partidas2022 = table.Column<int>(type: "int", nullable: false),
                    Gols2022 = table.Column<int>(type: "int", nullable: false),
                    Assists2022 = table.Column<int>(type: "int", nullable: false),
                    Partidas2021 = table.Column<int>(type: "int", nullable: false),
                    Gols2021 = table.Column<int>(type: "int", nullable: false),
                    Assists2021 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atacantes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atacantes");
        }
    }
}
