using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_AdocaoPets.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Canis",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    local = table.Column<string>(type: "TEXT", nullable: false),
                    numPets = table.Column<int>(type: "INTEGER", nullable: false),
                    numCaes = table.Column<int>(type: "INTEGER", nullable: false),
                    numGatos = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canis", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Especie = table.Column<string>(type: "TEXT", nullable: false),
                    Raca = table.Column<string>(type: "TEXT", nullable: false),
                    Idade = table.Column<int>(type: "INTEGER", nullable: true),
                    Sexo = table.Column<string>(type: "TEXT", nullable: false),
                    Vacinado = table.Column<bool>(type: "INTEGER", nullable: false),
                    PCD = table.Column<bool>(type: "INTEGER", nullable: false),
                    porte = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    CanilId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Canis_CanilId",
                        column: x => x.CanilId,
                        principalTable: "Canis",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contabilidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    valorMedioRacao = table.Column<double>(type: "REAL", nullable: false),
                    valorMedioVet = table.Column<double>(type: "REAL", nullable: false),
                    valorMedioVac = table.Column<double>(type: "REAL", nullable: false),
                    PetId = table.Column<int>(type: "INTEGER", nullable: false),
                    PetsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contabilidades", x => x.id);
                    table.ForeignKey(
                        name: "FK_Contabilidades_Pets_PetId",
                        column: x => x.PetId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contabilidades_Pets_PetsId",
                        column: x => x.PetsId,
                        principalTable: "Pets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidades_PetId",
                table: "Contabilidades",
                column: "PetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contabilidades_PetsId",
                table: "Contabilidades",
                column: "PetsId");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_CanilId",
                table: "Pets",
                column: "CanilId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contabilidades");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Canis");
        }
    }
}
