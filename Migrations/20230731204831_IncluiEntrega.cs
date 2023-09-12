using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace apiBrigadeiro.Migrations
{
    /// <inheritdoc />
    public partial class IncluiEntrega : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "frete",
                table: "compras",
                newName: "entregaid");

            migrationBuilder.CreateTable(
                name: "entregas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    endereco = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: false),
                    frete = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entregas", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_compras_entregaid",
                table: "compras",
                column: "entregaid");

            migrationBuilder.AddForeignKey(
                name: "FK_compras_entregas_entregaid",
                table: "compras",
                column: "entregaid",
                principalTable: "entregas",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_entregas_entregaid",
                table: "compras");

            migrationBuilder.DropTable(
                name: "entregas");

            migrationBuilder.DropIndex(
                name: "IX_compras_entregaid",
                table: "compras");

            migrationBuilder.RenameColumn(
                name: "entregaid",
                table: "compras",
                newName: "frete");
        }
    }
}
