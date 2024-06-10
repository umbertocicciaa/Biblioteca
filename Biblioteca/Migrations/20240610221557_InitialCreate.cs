using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Biblioteca.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codice_fiscale = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("author_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_name = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("category_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "member",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codice_ficale = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    joined_date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("member_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    category_id = table.Column<int>(type: "int", nullable: true),
                    publication_date = table.Column<DateOnly>(type: "date", nullable: true),
                    copies_owned = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("book_pkey", x => x.id);
                    table.ForeignKey(
                        name: "book_category_id_fkey",
                        column: x => x.category_id,
                        principalTable: "category",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "fine_payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    member_id = table.Column<int>(type: "int", nullable: true),
                    payment_date = table.Column<DateOnly>(type: "date", nullable: true),
                    payment_amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("fine_payment_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fine_payment_member_id_fkey",
                        column: x => x.member_id,
                        principalTable: "member",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "book_author",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false),
                    author_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("book_author_pkey", x => new { x.book_id, x.author_id });
                    table.ForeignKey(
                        name: "book_author_author_id_fkey",
                        column: x => x.author_id,
                        principalTable: "author",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "book_author_book_id_fkey",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "loan",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    member_id = table.Column<int>(type: "int", nullable: true),
                    book_id = table.Column<int>(type: "int", nullable: true),
                    loan_date = table.Column<DateOnly>(type: "date", nullable: true),
                    returned_date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("loan_pkey", x => x.id);
                    table.ForeignKey(
                        name: "loan_book_id_fkey",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "loan_member_id_fkey",
                        column: x => x.member_id,
                        principalTable: "member",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "reservation",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_id = table.Column<int>(type: "int", nullable: true),
                    member_id = table.Column<int>(type: "int", nullable: true),
                    reservation_date = table.Column<DateOnly>(type: "date", nullable: true),
                    reservation_Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("reservation_pkey", x => x.id);
                    table.ForeignKey(
                        name: "reservation_book_id_fkey",
                        column: x => x.book_id,
                        principalTable: "book",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "reservation_member_id_fkey",
                        column: x => x.member_id,
                        principalTable: "member",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "fine",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    member_id = table.Column<int>(type: "int", nullable: true),
                    loan_id = table.Column<int>(type: "int", nullable: true),
                    fine_date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("fine_pkey", x => x.id);
                    table.ForeignKey(
                        name: "fine_loan_id_fkey",
                        column: x => x.loan_id,
                        principalTable: "loan",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fine_member_id_fkey",
                        column: x => x.member_id,
                        principalTable: "member",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "author_codice_fiscale_key",
                table: "author",
                column: "codice_fiscale",
                unique: true,
                filter: "[codice_fiscale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_book_category_id",
                table: "book",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "IX_book_author_author_id",
                table: "book_author",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "category_category_name_key",
                table: "category",
                column: "category_name",
                unique: true,
                filter: "[category_name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_fine_loan_id",
                table: "fine",
                column: "loan_id");

            migrationBuilder.CreateIndex(
                name: "IX_fine_member_id",
                table: "fine",
                column: "member_id");

            migrationBuilder.CreateIndex(
                name: "IX_fine_payment_member_id",
                table: "fine_payment",
                column: "member_id");

            migrationBuilder.CreateIndex(
                name: "IX_loan_book_id",
                table: "loan",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_loan_member_id",
                table: "loan",
                column: "member_id");

            migrationBuilder.CreateIndex(
                name: "member_codice_ficale_key",
                table: "member",
                column: "codice_ficale",
                unique: true,
                filter: "[codice_ficale] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_book_id",
                table: "reservation",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservation_member_id",
                table: "reservation",
                column: "member_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_author");

            migrationBuilder.DropTable(
                name: "fine");

            migrationBuilder.DropTable(
                name: "fine_payment");

            migrationBuilder.DropTable(
                name: "reservation");

            migrationBuilder.DropTable(
                name: "author");

            migrationBuilder.DropTable(
                name: "loan");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "member");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
