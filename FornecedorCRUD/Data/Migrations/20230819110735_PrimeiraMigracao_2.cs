using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FornecedorCRUD.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigracao_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "CNPJ",
                table: "fornecedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 14);

            migrationBuilder.AlterColumn<long>(
                name: "CEP",
                table: "fornecedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CNPJ",
                table: "fornecedores",
                type: "int",
                maxLength: 14,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "CEP",
                table: "fornecedores",
                type: "int",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
