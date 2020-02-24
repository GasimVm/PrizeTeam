﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prize.data;

namespace Prize.Migrations
{
    [DbContext(typeof(ElPrizeContext))]
    [Migration("20200205191356_AddTrans")]
    partial class AddTrans
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prize.Models.Balans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Count")
                        .HasMaxLength(100);

                    b.Property<string>("Valuta");

                    b.HasKey("Id");

                    b.ToTable("Balans");
                });

            modelBuilder.Entity("Prize.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Prize.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActionName")
                        .HasMaxLength(150);

                    b.Property<bool>("LogStatus");

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Prize.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Prize.Models.StatusTrans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("StatusTrans");
                });

            modelBuilder.Entity("Prize.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int>("GetUserId");

                    b.Property<DateTime>("SendDate");

                    b.Property<int>("StatusTransId");

                    b.Property<string>("TransactionNubmer")
                        .HasMaxLength(150);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("StatusTransId");

                    b.HasIndex("UserId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("Prize.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Acvited");

                    b.Property<int>("BalansId");

                    b.Property<int>("CountryId");

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<string>("Firstame")
                        .HasMaxLength(150);

                    b.Property<string>("Lastname")
                        .HasMaxLength(150);

                    b.Property<string>("Password")
                        .HasMaxLength(150);

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("RoleId");

                    b.Property<string>("Username")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.HasIndex("BalansId");

                    b.HasIndex("CountryId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Prize.Models.Log", b =>
                {
                    b.HasOne("Prize.Models.User", "User")
                        .WithMany("Logs")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prize.Models.Transaction", b =>
                {
                    b.HasOne("Prize.Models.StatusTrans", "StatusTrans")
                        .WithMany("Transactions")
                        .HasForeignKey("StatusTransId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prize.Models.User", "User")
                        .WithMany("Transactions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Prize.Models.User", b =>
                {
                    b.HasOne("Prize.Models.Balans", "Balans")
                        .WithMany("Users")
                        .HasForeignKey("BalansId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prize.Models.Country", "Country")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Prize.Models.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
