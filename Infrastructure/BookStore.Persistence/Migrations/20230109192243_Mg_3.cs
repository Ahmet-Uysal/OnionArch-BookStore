using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mg3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Files_BookImageFileId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_BookStockKeepUnits_BookStockKeepUnitId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_BookStockKeepUnitId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookImageFileId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookStockKeepUnitId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "BookImageFileId",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "BookImageFileBookStockKeepUnit",
                columns: table => new
                {
                    BookImagesId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BooksId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookImageFileBookStockKeepUnit", x => new { x.BookImagesId, x.BooksId });
                    table.ForeignKey(
                        name: "FK_BookImageFileBookStockKeepUnit_BookStockKeepUnits_BooksId",
                        column: x => x.BooksId,
                        principalTable: "BookStockKeepUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookImageFileBookStockKeepUnit_Files_BookImagesId",
                        column: x => x.BookImagesId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_BookImageFileBookStockKeepUnit_BooksId",
                table: "BookImageFileBookStockKeepUnit",
                column: "BooksId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookImageFileBookStockKeepUnit");

            migrationBuilder.AddColumn<Guid>(
                name: "BookStockKeepUnitId",
                table: "Files",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.AddColumn<Guid>(
                name: "BookImageFileId",
                table: "Books",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_Files_BookStockKeepUnitId",
                table: "Files",
                column: "BookStockKeepUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookImageFileId",
                table: "Books",
                column: "BookImageFileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Files_BookImageFileId",
                table: "Books",
                column: "BookImageFileId",
                principalTable: "Files",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_BookStockKeepUnits_BookStockKeepUnitId",
                table: "Files",
                column: "BookStockKeepUnitId",
                principalTable: "BookStockKeepUnits",
                principalColumn: "Id");
        }
    }
}
