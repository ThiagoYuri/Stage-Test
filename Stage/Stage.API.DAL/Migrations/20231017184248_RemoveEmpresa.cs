using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class RemoveEmpresa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Processo_Empresa_PK_Empresa",
                table: "Processo");

            migrationBuilder.DropTable(
                name: "AreaEmpresa");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropIndex(
                name: "IX_Processo_PK_Empresa",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "PK_Empresa",
                table: "Processo");

            migrationBuilder.DropColumn(
                name: "PK_Empresa",
                table: "Area");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PK_Empresa",
                table: "Processo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PK_Empresa",
                table: "Area",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PK_Area = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AreaEmpresa",
                columns: table => new
                {
                    PK_Area = table.Column<int>(type: "int", nullable: false),
                    PK_Empresa = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaEmpresa", x => new { x.PK_Area, x.PK_Empresa });
                    table.ForeignKey(
                        name: "FK_AreaEmpresa_Area_PK_Empresa",
                        column: x => x.PK_Empresa,
                        principalTable: "Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_AreaEmpresa_Empresa_PK_Area",
                        column: x => x.PK_Area,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_PK_Empresa",
                table: "Processo",
                column: "PK_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_AreaEmpresa_PK_Empresa",
                table: "AreaEmpresa",
                column: "PK_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Empresa_CNPJ",
                table: "Empresa",
                column: "CNPJ",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Processo_Empresa_PK_Empresa",
                table: "Processo",
                column: "PK_Empresa",
                principalTable: "Empresa",
                principalColumn: "Id");
        }
    }
}
