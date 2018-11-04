﻿// <auto-generated />
using System;
using FamilyMealFavoites.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyMealFavoites.Migrations
{
    [DbContext(typeof(FamilyFavoritesDbContext))]
    [Migration("20181104181747_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FamilyMealFavoites.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountNumber");

                    b.HasKey("ID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.AccountMenu", b =>
                {
                    b.Property<int>("MenuID");

                    b.Property<int>("AccountID");

                    b.HasKey("MenuID", "AccountID");

                    b.HasIndex("AccountID");

                    b.ToTable("AccountMenus");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IngredientType");

                    b.Property<int?>("MenuID");

                    b.HasKey("ID");

                    b.HasIndex("MenuID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.Member", b =>
                {
                    b.Property<int>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountMenuAccountID");

                    b.Property<int?>("AccountMenuMenuID");

                    b.Property<int>("AccountNumber");

                    b.Property<string>("FirstName");

                    b.Property<string>("Lastname");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("MemberID");

                    b.HasIndex("AccountNumber");

                    b.HasIndex("AccountMenuMenuID", "AccountMenuAccountID");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvgRating");

                    b.Property<string>("DishName");

                    b.HasKey("ID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.MenuRating", b =>
                {
                    b.Property<int>("MenuID");

                    b.Property<int>("MemeberID");

                    b.Property<int?>("MemberID");

                    b.Property<int>("Rating");

                    b.HasKey("MenuID", "MemeberID");

                    b.HasIndex("MemberID");

                    b.ToTable("MenuRatings");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.AccountMenu", b =>
                {
                    b.HasOne("FamilyMealFavoites.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyMealFavoites.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.Ingredient", b =>
                {
                    b.HasOne("FamilyMealFavoites.Models.Menu")
                        .WithMany("Ingredients")
                        .HasForeignKey("MenuID");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.Member", b =>
                {
                    b.HasOne("FamilyMealFavoites.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountNumber")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FamilyMealFavoites.Models.AccountMenu")
                        .WithMany("Members")
                        .HasForeignKey("AccountMenuMenuID", "AccountMenuAccountID");
                });

            modelBuilder.Entity("FamilyMealFavoites.Models.MenuRating", b =>
                {
                    b.HasOne("FamilyMealFavoites.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberID");

                    b.HasOne("FamilyMealFavoites.Models.Menu", "Menu")
                        .WithMany()
                        .HasForeignKey("MenuID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}