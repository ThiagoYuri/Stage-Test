using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class reovpk_processo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Empresa_PK_Processos",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "PK_Processos",
                table: "Empresa");

            migrationBuilder.RenameColumn(
                name: "PK_Processos",
                table: "Processo",
                newName: "EmpresaId");

            migrationBuilder.RenameIndex(
                name: "IX_Processo_PK_Processos",
                table: "Processo",
                newName: "IX_Processo_EmpresaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Empresa_EmpresaId",
                table: "Processo",
                column: "EmpresaId",
                principalTable: "Empresa",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Empresa_EmpresaId",
                table: "Processo");

            migrationBuilder.RenameColumn(
                name: "EmpresaId",
                table: "Processo",
                newName: "PK_Processos");

            migrationBuilder.RenameIndex(
                name: "IX_Processo_EmpresaId",
                table: "Processo",
                newName: "IX_Processo_PK_Processos");

            migrationBuilder.AddColumn<int>(
                name: "PK_Processos",
                table: "Empresa",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Empresa_PK_Processos",
                table: "Processo",
                column: "PK_Processos",
                principalTable: "Empresa",
                principalColumn: "Id");
        }
    }
}
