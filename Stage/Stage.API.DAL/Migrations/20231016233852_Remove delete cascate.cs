using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Removedeletecascate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PK_Empresa = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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

            migrationBuilder.CreateTable(
                name: "Processo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProcesso = table.Column<int>(type: "int", nullable: false),
                    ProcessoPaiId = table.Column<int>(type: "int", nullable: true),
                    PK_Area = table.Column<int>(type: "int", nullable: false),
                    PK_Empresa = table.Column<int>(type: "int", nullable: false),
                    EmpresaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processo_Area_PK_Area",
                        column: x => x.PK_Area,
                        principalTable: "Area",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Processo_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Processo_Empresa_PK_Empresa",
                        column: x => x.PK_Empresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Processo_Processo_ProcessoPaiId",
                        column: x => x.ProcessoPaiId,
                        principalTable: "Processo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaEmpresa_PK_Empresa",
                table: "AreaEmpresa",
                column: "PK_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_EmpresaId",
                table: "Processo",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_PK_Area",
                table: "Processo",
                column: "PK_Area");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_PK_Empresa",
                table: "Processo",
                column: "PK_Empresa");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_ProcessoPaiId",
                table: "Processo",
                column: "ProcessoPaiId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaEmpresa");

            migrationBuilder.DropTable(
                name: "Processo");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Empresa");
        }
    }
}
