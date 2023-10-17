using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stage.API.DAL.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
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
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoProcesso = table.Column<int>(type: "int", nullable: false),
                    PK_ProcessoPai = table.Column<int>(type: "int", nullable: true),
                    PK_Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processo_Area_PK_Area",
                        column: x => x.PK_Area,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Processo_Processo_PK_ProcessoPai",
                        column: x => x.PK_ProcessoPai,
                        principalTable: "Processo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Processo_PK_Area",
                table: "Processo",
                column: "PK_Area");

            migrationBuilder.CreateIndex(
                name: "IX_Processo_PK_ProcessoPai",
                table: "Processo",
                column: "PK_ProcessoPai");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processo");

            migrationBuilder.DropTable(
                name: "Area");
        }
    }
}
