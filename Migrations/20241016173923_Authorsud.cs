using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Georgea_Adina_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Authorsud : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Authors",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Authors",
                newName: "Id");
        }
    }
}
