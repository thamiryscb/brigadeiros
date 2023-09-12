using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace apiBrigadeiro.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Endereço = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Senha = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ListaDoces = table.Column<string>(type: "text", nullable: true),
                    ValorTotal = table.Column<int>(type: "integer", nullable: false),
                    Frete = table.Column<int>(type: "integer", nullable: false),
                    FormaPagamento = table.Column<string>(type: "text", nullable: true),
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compras_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Valores = table.Column<int>(type: "integer", nullable: false),
                    Quantidades = table.Column<int>(type: "integer", nullable: false),
                    Sabores = table.Column<string>(type: "text", nullable: true),
                    ComprasId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doces_Compras_ComprasId",
                        column: x => x.ComprasId,
                        principalTable: "Compras",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClienteId",
                table: "Compras",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Doces_ComprasId",
                table: "Doces",
                column: "ComprasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doces");

            migrationBuilder.DropTable(
                name: "Compras");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
