using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hearth_Projeto.Migrations
{
    /// <inheritdoc />
    public partial class atualizei : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Pessoa",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Pessoa");
        }
    }
}
