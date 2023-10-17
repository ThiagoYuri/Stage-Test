using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CNPJunique : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Empresa_CNPJ",
                table: "Empresa",
                column: "CNPJ",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Empresa_CNPJ",
                table: "Empresa");
        }
    }
}
