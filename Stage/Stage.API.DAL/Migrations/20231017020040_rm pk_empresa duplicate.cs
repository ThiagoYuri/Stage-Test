using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class rmpk_empresaduplicate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Empresa_EmpresaId",
                table: "Processo");

            migrationBuilder.DropIndex(
                name: "IX_Processo_EmpresaId",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "EmpresaId",
                table: "Processo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpresaId",
                table: "Processo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Processo_EmpresaId",
                table: "Processo",
                column: "EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Empresa_EmpresaId",
                table: "Processo",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");
        }
    }
}
