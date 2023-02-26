using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1670_Final.Data.Migrations
{
    public partial class intialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameBook = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Book_author = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Book_publisher = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Book_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Book_price = table.Column<double>(type: "float", nullable: false),
                    Book_image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Book_quantity = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookId",
                table: "Order",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_UserId",
                table: "Order",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
