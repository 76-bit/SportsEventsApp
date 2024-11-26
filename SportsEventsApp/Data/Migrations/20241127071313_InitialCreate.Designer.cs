﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsEventsApp.Data;

#nullable disable

namespace SportsEventsApp.Data.Migrations
{
    [DbContext(typeof(SportEventsAppDbContext))]
    [Migration("20241127071313_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SportsEventsApp.Data.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The id of the category");

                    b.Property<double>("MaxWeight")
                        .HasColumnType("float")
                        .HasComment("The minimum required weight needed to clasify as this weight, in pounds.");

                    b.Property<double>("MinWeight")
                        .HasColumnType("float")
                        .HasComment("The minimum required weight needed to clasify as this weight, in pounds.");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("The name of the category, exemple: LightWeight, MiddleWeight....");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2dcedebe-e294-49fa-8002-e7ba2cdece92"),
                            MaxWeight = 115.0,
                            MinWeight = 106.0,
                            Name = "Strawweight"
                        },
                        new
                        {
                            Id = new Guid("aaf2d3df-93d1-48a5-be9d-7691f4c74f86"),
                            MaxWeight = 125.0,
                            MinWeight = 115.0,
                            Name = "Flyweight "
                        },
                        new
                        {
                            Id = new Guid("d4cc6824-f785-4f37-9b55-edd0ddf1c85a"),
                            MaxWeight = 135.0,
                            MinWeight = 125.0,
                            Name = "Bantamweight  "
                        },
                        new
                        {
                            Id = new Guid("b5c2d930-7285-49c2-97e6-04ced45c1235"),
                            MaxWeight = 145.0,
                            MinWeight = 135.0,
                            Name = "Featherweight  "
                        },
                        new
                        {
                            Id = new Guid("e2dd7dab-5044-4e6d-8445-638f012645bd"),
                            MaxWeight = 155.0,
                            MinWeight = 145.0,
                            Name = "Lightweight "
                        },
                        new
                        {
                            Id = new Guid("62ea6f95-fe56-4e62-abc8-305cb3b502df"),
                            MaxWeight = 170.0,
                            MinWeight = 155.0,
                            Name = "Welterweight  "
                        },
                        new
                        {
                            Id = new Guid("4bbfcd06-c89f-4749-8b06-ab9c592c226f"),
                            MaxWeight = 185.0,
                            MinWeight = 170.0,
                            Name = "Middleweight  "
                        },
                        new
                        {
                            Id = new Guid("d0f549d2-b1ac-4067-b896-75d39ce1c135"),
                            MaxWeight = 205.0,
                            MinWeight = 185.0,
                            Name = "Light heavyweight "
                        },
                        new
                        {
                            Id = new Guid("d36f037b-0335-46f4-ae64-b95aa8050327"),
                            MaxWeight = 265.0,
                            MinWeight = 205.0,
                            Name = "Middleweight  "
                        });
                });

            modelBuilder.Entity("SportsEventsApp.Data.Fight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("Unique identifier of the fight");

                    b.Property<DateTime>("DateOfTheFight")
                        .HasColumnType("datetime2")
                        .HasComment("The date of the fight, not the date of its adding");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("A brief decription of the fight details, also has a minimum and maximum characher limit");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("url of the image");

                    b.Property<string>("PublisherId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("The id of the admin that added the fight, note that users and guests cannot add or delete fights");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("The name of the title, has a minimum and maximum characher limit");

                    b.HasKey("Id");

                    b.HasIndex("PublisherId");

                    b.ToTable("Fights");
                });

            modelBuilder.Entity("SportsEventsApp.Data.Fighter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The unique identifier of the fighter");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier")
                        .HasComment("The weight class (category) of the fighter");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("First name of the fighter");

                    b.Property<double>("Height")
                        .HasColumnType("float")
                        .HasComment("The height of the fighter in cm");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Last name of the fighter");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Nickname of the fighter");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Fighters");
                });

            modelBuilder.Entity("SportsEventsApp.Data.FighterFight", b =>
                {
                    b.Property<Guid>("FighterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FightId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("FighterId", "FightId");

                    b.HasIndex("FightId");

                    b.ToTable("FightersFights");
                });

            modelBuilder.Entity("SportsEventsApp.Data.UserFight", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("FightId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "FightId");

                    b.HasIndex("FightId");

                    b.ToTable("UsersFights");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SportsEventsApp.Data.Fight", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Publisher")
                        .WithMany()
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("SportsEventsApp.Data.Fighter", b =>
                {
                    b.HasOne("SportsEventsApp.Data.Category", "Category")
                        .WithMany("Fighters")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SportsEventsApp.Data.FighterFight", b =>
                {
                    b.HasOne("SportsEventsApp.Data.Fight", "Fight")
                        .WithMany("FighterFights")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SportsEventsApp.Data.Fighter", "Fighter")
                        .WithMany()
                        .HasForeignKey("FighterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fight");

                    b.Navigation("Fighter");
                });

            modelBuilder.Entity("SportsEventsApp.Data.UserFight", b =>
                {
                    b.HasOne("SportsEventsApp.Data.Fight", "Fight")
                        .WithMany("UsersFights")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fight");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsEventsApp.Data.Category", b =>
                {
                    b.Navigation("Fighters");
                });

            modelBuilder.Entity("SportsEventsApp.Data.Fight", b =>
                {
                    b.Navigation("FighterFights");

                    b.Navigation("UsersFights");
                });
#pragma warning restore 612, 618
        }
    }
}
