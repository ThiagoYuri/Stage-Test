using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updtempesa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CNPJ",
                table: "Empresa",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CNPJ",
                table: "Empresa");
        }
    }
}
