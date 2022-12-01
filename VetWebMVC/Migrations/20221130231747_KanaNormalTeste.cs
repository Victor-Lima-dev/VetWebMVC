using Microsoft.EntityFrameworkCore.Migrations;
using VetWeb;

#nullable disable

namespace VetWebMVC.Migrations
{
    /// <inheritdoc />
    public partial class KanaNormalTeste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Parametros(FrequenciaCardiaca, FrequenciaRespiratoria, PressaoArterialSistemica, Hematocrito, Leucocitos)" +
                "VALUES(" +
                "'Normal','Normal','Normal','Normal','Normal')");           
            migrationBuilder.Sql("INSERT INTO Animais(Nome, FaseDaVida,Sexo,Comorbidade, Condicao, ParametrosId)" +
                "VALUES('Kana','Jovem', 'Femea', 'Normal', 'Normal',1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Animais");
            migrationBuilder.Sql("DELETE FROM Parametros");
        }
    }
}
