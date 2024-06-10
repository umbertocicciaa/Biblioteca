﻿// <auto-generated />
using System;
using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Biblioteca.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    [Migration("20240610221557_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Biblioteca.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodiceFiscale")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("codice_fiscale");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("author_pkey");

                    b.HasIndex(new[] { "CodiceFiscale" }, "author_codice_fiscale_key")
                        .IsUnique()
                        .HasFilter("[codice_fiscale] IS NOT NULL");

                    b.ToTable("author", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int?>("CopiesOwned")
                        .HasColumnType("int")
                        .HasColumnName("copies_owned");

                    b.Property<DateOnly?>("PublicationDate")
                        .HasColumnType("date")
                        .HasColumnName("publication_date");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("book_pkey");

                    b.HasIndex("CategoryId");

                    b.ToTable("book", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("category_name");

                    b.HasKey("Id")
                        .HasName("category_pkey");

                    b.HasIndex(new[] { "CategoryName" }, "category_category_name_key")
                        .IsUnique()
                        .HasFilter("[category_name] IS NOT NULL");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Fine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly?>("FineDate")
                        .HasColumnType("date")
                        .HasColumnName("fine_date");

                    b.Property<int?>("LoanId")
                        .HasColumnType("int")
                        .HasColumnName("loan_id");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("member_id");

                    b.HasKey("Id")
                        .HasName("fine_pkey");

                    b.HasIndex("LoanId");

                    b.HasIndex("MemberId");

                    b.ToTable("fine", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.FinePayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("member_id");

                    b.Property<decimal?>("PaymentAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("payment_amount");

                    b.Property<DateOnly?>("PaymentDate")
                        .HasColumnType("date")
                        .HasColumnName("payment_date");

                    b.HasKey("Id")
                        .HasName("fine_payment_pkey");

                    b.HasIndex("MemberId");

                    b.ToTable("fine_payment", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<DateOnly?>("LoanDate")
                        .HasColumnType("date")
                        .HasColumnName("loan_date");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("member_id");

                    b.Property<DateOnly?>("ReturnedDate")
                        .HasColumnType("date")
                        .HasColumnName("returned_date");

                    b.HasKey("Id")
                        .HasName("loan_pkey");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("loan", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodiceFicale")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("codice_ficale");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first_name");

                    b.Property<DateOnly?>("JoinedDate")
                        .HasColumnType("date")
                        .HasColumnName("joined_date");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last_name");

                    b.HasKey("Id")
                        .HasName("member_pkey");

                    b.HasIndex(new[] { "CodiceFicale" }, "member_codice_ficale_key")
                        .IsUnique()
                        .HasFilter("[codice_ficale] IS NOT NULL");

                    b.ToTable("member", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int")
                        .HasColumnName("member_id");

                    b.Property<DateOnly?>("ReservationDate")
                        .HasColumnType("date")
                        .HasColumnName("reservation_date");

                    b.Property<string>("ReservationStatus")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reservation_Status");

                    b.HasKey("Id")
                        .HasName("reservation_pkey");

                    b.HasIndex("BookId");

                    b.HasIndex("MemberId");

                    b.ToTable("reservation", (string)null);
                });

            modelBuilder.Entity("BookAuthor", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int")
                        .HasColumnName("book_id");

                    b.Property<int>("AuthorId")
                        .HasColumnType("int")
                        .HasColumnName("author_id");

                    b.HasKey("BookId", "AuthorId")
                        .HasName("book_author_pkey");

                    b.HasIndex("AuthorId");

                    b.ToTable("book_author", (string)null);
                });

            modelBuilder.Entity("Biblioteca.Models.Book", b =>
                {
                    b.HasOne("Biblioteca.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("book_category_id_fkey");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Biblioteca.Models.Fine", b =>
                {
                    b.HasOne("Biblioteca.Models.Loan", "Loan")
                        .WithMany("Fines")
                        .HasForeignKey("LoanId")
                        .HasConstraintName("fine_loan_id_fkey");

                    b.HasOne("Biblioteca.Models.Member", "Member")
                        .WithMany("Fines")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fine_member_id_fkey");

                    b.Navigation("Loan");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Biblioteca.Models.FinePayment", b =>
                {
                    b.HasOne("Biblioteca.Models.Member", "Member")
                        .WithMany("FinePayments")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("fine_payment_member_id_fkey");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Biblioteca.Models.Loan", b =>
                {
                    b.HasOne("Biblioteca.Models.Book", "Book")
                        .WithMany("Loans")
                        .HasForeignKey("BookId")
                        .HasConstraintName("loan_book_id_fkey");

                    b.HasOne("Biblioteca.Models.Member", "Member")
                        .WithMany("Loans")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("loan_member_id_fkey");

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Biblioteca.Models.Reservation", b =>
                {
                    b.HasOne("Biblioteca.Models.Book", "Book")
                        .WithMany("Reservations")
                        .HasForeignKey("BookId")
                        .HasConstraintName("reservation_book_id_fkey");

                    b.HasOne("Biblioteca.Models.Member", "Member")
                        .WithMany("Reservations")
                        .HasForeignKey("MemberId")
                        .HasConstraintName("reservation_member_id_fkey");

                    b.Navigation("Book");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("BookAuthor", b =>
                {
                    b.HasOne("Biblioteca.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .IsRequired()
                        .HasConstraintName("book_author_author_id_fkey");

                    b.HasOne("Biblioteca.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BookId")
                        .IsRequired()
                        .HasConstraintName("book_author_book_id_fkey");
                });

            modelBuilder.Entity("Biblioteca.Models.Book", b =>
                {
                    b.Navigation("Loans");

                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("Biblioteca.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Biblioteca.Models.Loan", b =>
                {
                    b.Navigation("Fines");
                });

            modelBuilder.Entity("Biblioteca.Models.Member", b =>
                {
                    b.Navigation("FinePayments");

                    b.Navigation("Fines");

                    b.Navigation("Loans");

                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
