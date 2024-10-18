using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Georgea_Adina_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddAuthorsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorsId",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorsId",
                table: "Book",
                column: "AuthorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorsId",
                table: "Book",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorsId",
                table: "Book");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorsId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorsId",
                table: "Book");
        }
    }
}
