using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStore.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookStockKeepUnits_Books_BookId",
                table: "BookStockKeepUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_BookStockKeepUnits_Publishers_PublisherId",
                table: "BookStockKeepUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Endpoints_Menus_MenuId",
                table: "Endpoints");

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuId",
                table: "Endpoints",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublisherId",
                table: "BookStockKeepUnits",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookId",
                table: "BookStockKeepUnits",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)")
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_BookStockKeepUnits_Books_BookId",
                table: "BookStockKeepUnits",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookStockKeepUnits_Publishers_PublisherId",
                table: "BookStockKeepUnits",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Endpoints_Menus_MenuId",
                table: "Endpoints",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookStockKeepUnits_Books_BookId",
                table: "BookStockKeepUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_BookStockKeepUnits_Publishers_PublisherId",
                table: "BookStockKeepUnits");

            migrationBuilder.DropForeignKey(
                name: "FK_Endpoints_Menus_MenuId",
                table: "Endpoints");

            migrationBuilder.AlterColumn<Guid>(
                name: "MenuId",
                table: "Endpoints",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "PublisherId",
                table: "BookStockKeepUnits",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AlterColumn<Guid>(
                name: "BookId",
                table: "BookStockKeepUnits",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci",
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true)
                .OldAnnotation("Relational:Collation", "ascii_general_ci");

            migrationBuilder.AddForeignKey(
                name: "FK_BookStockKeepUnits_Books_BookId",
                table: "BookStockKeepUnits",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookStockKeepUnits_Publishers_PublisherId",
                table: "BookStockKeepUnits",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Endpoints_Menus_MenuId",
                table: "Endpoints",
                column: "MenuId",
                principalTable: "Menus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
