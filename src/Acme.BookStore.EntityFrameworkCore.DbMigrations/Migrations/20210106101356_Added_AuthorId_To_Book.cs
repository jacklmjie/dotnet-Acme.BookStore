using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Acme.BookStore.Migrations
{
    public partial class Added_AuthorId_To_Book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "t_Books",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_t_Books_AuthorId",
                table: "t_Books",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_t_Books_t_Authors_AuthorId",
                table: "t_Books",
                column: "AuthorId",
                principalTable: "t_Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_t_Books_t_Authors_AuthorId",
                table: "t_Books");

            migrationBuilder.DropIndex(
                name: "IX_t_Books_AuthorId",
                table: "t_Books");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "t_Books");
        }
    }
}
