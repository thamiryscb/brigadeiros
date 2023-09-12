using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiBrigadeiro.Migrations
{
    /// <inheritdoc />
    public partial class alteraCases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clientes_ClienteId",
                table: "Compras");

            migrationBuilder.DropForeignKey(
                name: "FK_Doces_Compras_ComprasId",
                table: "Doces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doces",
                table: "Doces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Compras",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.RenameTable(
                name: "Doces",
                newName: "doces");

            migrationBuilder.RenameTable(
                name: "Compras",
                newName: "compras");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "clientes");

            migrationBuilder.RenameColumn(
                name: "Valores",
                table: "doces",
                newName: "valores");

            migrationBuilder.RenameColumn(
                name: "Sabores",
                table: "doces",
                newName: "sabores");

            migrationBuilder.RenameColumn(
                name: "Quantidades",
                table: "doces",
                newName: "quantidades");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "doces",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "ComprasId",
                table: "doces",
                newName: "comprasid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "doces",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Doces_ComprasId",
                table: "doces",
                newName: "IX_doces_comprasid");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "compras",
                newName: "valortotal");

            migrationBuilder.RenameColumn(
                name: "ListaDoces",
                table: "compras",
                newName: "listadoces");

            migrationBuilder.RenameColumn(
                name: "Frete",
                table: "compras",
                newName: "frete");

            migrationBuilder.RenameColumn(
                name: "FormaPagamento",
                table: "compras",
                newName: "formapagamento");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "compras",
                newName: "clienteid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "compras",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Compras_ClienteId",
                table: "compras",
                newName: "IX_compras_clienteid");

            migrationBuilder.RenameColumn(
                name: "Telefone",
                table: "clientes",
                newName: "telefone");

            migrationBuilder.RenameColumn(
                name: "Senha",
                table: "clientes",
                newName: "senha");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "clientes",
                newName: "nome");

            migrationBuilder.RenameColumn(
                name: "Endereço",
                table: "clientes",
                newName: "endereço");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clientes",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "clientes",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_doces",
                table: "doces",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_compras",
                table: "compras",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clientes",
                table: "clientes",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_compras_clientes_clienteid",
                table: "compras",
                column: "clienteid",
                principalTable: "clientes",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_doces_compras_comprasid",
                table: "doces",
                column: "comprasid",
                principalTable: "compras",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_compras_clientes_clienteid",
                table: "compras");

            migrationBuilder.DropForeignKey(
                name: "FK_doces_compras_comprasid",
                table: "doces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_doces",
                table: "doces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_compras",
                table: "compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clientes",
                table: "clientes");

            migrationBuilder.RenameTable(
                name: "doces",
                newName: "Doces");

            migrationBuilder.RenameTable(
                name: "compras",
                newName: "Compras");

            migrationBuilder.RenameTable(
                name: "clientes",
                newName: "Clientes");

            migrationBuilder.RenameColumn(
                name: "valores",
                table: "Doces",
                newName: "Valores");

            migrationBuilder.RenameColumn(
                name: "sabores",
                table: "Doces",
                newName: "Sabores");

            migrationBuilder.RenameColumn(
                name: "quantidades",
                table: "Doces",
                newName: "Quantidades");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Doces",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "comprasid",
                table: "Doces",
                newName: "ComprasId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Doces",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_doces_comprasid",
                table: "Doces",
                newName: "IX_Doces_ComprasId");

            migrationBuilder.RenameColumn(
                name: "valortotal",
                table: "Compras",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "listadoces",
                table: "Compras",
                newName: "ListaDoces");

            migrationBuilder.RenameColumn(
                name: "frete",
                table: "Compras",
                newName: "Frete");

            migrationBuilder.RenameColumn(
                name: "formapagamento",
                table: "Compras",
                newName: "FormaPagamento");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "Compras",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Compras",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_compras_clienteid",
                table: "Compras",
                newName: "IX_Compras_ClienteId");

            migrationBuilder.RenameColumn(
                name: "telefone",
                table: "Clientes",
                newName: "Telefone");

            migrationBuilder.RenameColumn(
                name: "senha",
                table: "Clientes",
                newName: "Senha");

            migrationBuilder.RenameColumn(
                name: "nome",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "endereço",
                table: "Clientes",
                newName: "Endereço");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Clientes",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doces",
                table: "Doces",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Compras",
                table: "Compras",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clientes_ClienteId",
                table: "Compras",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Doces_Compras_ComprasId",
                table: "Doces",
                column: "ComprasId",
                principalTable: "Compras",
                principalColumn: "Id");
        }
    }
}
