using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VetWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EfeitoSistemico",
                columns: table => new
                {
                    EfeitoSistemicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PodeAumentarFrequenciaCardiaca = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirFrequenciaCardiaca = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarFrequenciaRespiratoria = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirFrequenciaRespiratoria = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarPressaoArterial = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirPressaoArterial = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarHematocritos = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirHematocritos = table.Column<bool>(type: "bit", nullable: false),
                    PodeAumentarLeucocitos = table.Column<bool>(type: "bit", nullable: false),
                    PodeDiminuirLeucocitos = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EfeitoSistemico", x => x.EfeitoSistemicoId);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    ParametrosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrequenciaCardiaca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FrequenciaRespiratoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PressaoArterialSistemica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hematocrito = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Leucocitos = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.ParametrosId);
                });

            migrationBuilder.CreateTable(
                name: "Remedios",
                columns: table => new
                {
                    RemedioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrincipioAtivo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MecanismoAcao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViaAdministracao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfeitoAdverso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfeitoSistemicoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Remedios", x => x.RemedioId);
                    table.ForeignKey(
                        name: "FK_Remedios_EfeitoSistemico_EfeitoSistemicoId",
                        column: x => x.EfeitoSistemicoId,
                        principalTable: "EfeitoSistemico",
                        principalColumn: "EfeitoSistemicoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaseDaVida = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comorbidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParametrosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.AnimalId);
                    table.ForeignKey(
                        name: "FK_Animais_Parametros_ParametrosId",
                        column: x => x.ParametrosId,
                        principalTable: "Parametros",
                        principalColumn: "ParametrosId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_ParametrosId",
                table: "Animais",
                column: "ParametrosId");

            migrationBuilder.CreateIndex(
                name: "IX_Remedios_EfeitoSistemicoId",
                table: "Remedios",
                column: "EfeitoSistemicoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Remedios");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "EfeitoSistemico");
        }
    }
}
