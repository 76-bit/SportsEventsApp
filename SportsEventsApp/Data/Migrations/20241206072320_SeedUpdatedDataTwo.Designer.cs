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
    [Migration("20241206072320_SeedUpdatedDataTwo")]
    partial class SeedUpdatedDataTwo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fighter", b =>
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
                        .HasComment("The height of the fighter in feet");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("URL for the fighter's image");

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

                    b.Property<int>("Reach")
                        .HasColumnType("int")
                        .HasComment("The fighter's reach in inches");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Fighters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4bff9e8a-5832-4c7a-b9a0-c0a94b801415"),
                            CategoryId = new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"),
                            DateOfBirth = new DateTime(1988, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Conor",
                            Height = 5.7999999999999998,
                            ImageUrl = "https://www.sherdog.com/image_crop/200/300/_images/fighter/20220325093124_Conor_McGregor_ff.JPG",
                            LastName = "McGregor",
                            NickName = "The Notorious",
                            Reach = 74
                        },
                        new
                        {
                            Id = new Guid("1550013c-e044-4f0e-a337-3bfbde73f510"),
                            CategoryId = new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"),
                            DateOfBirth = new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Khabib",
                            Height = 5.0999999999999996,
                            ImageUrl = "https://www.datocms-assets.com/99008/1696277875-untitled-design-5.png",
                            LastName = "Nurmagomedov",
                            NickName = "The Eagle",
                            Reach = 70
                        },
                        new
                        {
                            Id = new Guid("500391a5-d4ba-4f6e-8b35-880f75398eef"),
                            CategoryId = new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"),
                            DateOfBirth = new DateTime(1989, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Israel",
                            Height = 6.4000000000000004,
                            ImageUrl = "https://glory.pinkyellow.network/assets/fighters/israel-the-last-style-bender-adesanya/thumbnail.jpg",
                            LastName = "Adesanya",
                            NickName = "The Last Stylebender",
                            Reach = 80
                        },
                        new
                        {
                            Id = new Guid("67de9f12-8221-42f2-9474-b89953651748"),
                            CategoryId = new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"),
                            DateOfBirth = new DateTime(1987, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Alex",
                            Height = 6.4000000000000004,
                            ImageUrl = "https://dmxg5wxfqgb4u.cloudfront.net/styles/card_advance_small_280x356/s3/2024-10/100324-Alex-Pereira-UFC-307-Press-Conference-THUMB-GettyImages-2176549340.jpg?itok=5C_djKwj",
                            LastName = "Pereira",
                            NickName = "Poatan",
                            Reach = 79
                        },
                        new
                        {
                            Id = new Guid("0093a69e-632f-4934-bf45-23235ad134db"),
                            CategoryId = new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"),
                            DateOfBirth = new DateTime(1975, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Anderson",
                            Height = 6.2000000000000002,
                            ImageUrl = "https://www.denverpost.com/wp-content/uploads/2016/04/20140801_084436_anderson-silva.jpg?w=640",
                            LastName = "Silva",
                            NickName = "The Spider",
                            Reach = 77
                        },
                        new
                        {
                            Id = new Guid("6301e156-7b95-4a58-b3e9-aee197bcfdf1"),
                            CategoryId = new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"),
                            DateOfBirth = new DateTime(1977, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstName = "Chael",
                            Height = 6.0999999999999996,
                            ImageUrl = "https://www.sherdog.com/image_crop/200/300/_images/fighter/20131219125416_chael_sonnen.JPG",
                            LastName = "Sonnen",
                            NickName = "The American Gangster",
                            Reach = 73
                        });
                });

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

                    b.HasData(
                        new
                        {
                            Id = "51ac4bdd-94b1-4555-bb6e-382c55dd0c49",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "aaa700d3-3d37-410d-abef-b482d2ac1531",
                            Email = "admin@mma.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MMA.COM",
                            NormalizedUserName = "ADMIN@MMA.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEETcCZge/JWWAGrXnhb05+JwixpbGvW6EcOFWulleh57+4eOKr4vs8HOUOuaRBsG8w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "7c51cd58-53ed-4eba-8944-a1aed3bc9a00",
                            TwoFactorEnabled = false,
                            UserName = "admin@mma.com"
                        });
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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

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
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

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
                            Id = new Guid("ebbb6ece-1add-4e79-9c6a-ac33de3efde9"),
                            MaxWeight = 115.0,
                            MinWeight = 106.0,
                            Name = "Strawweight"
                        },
                        new
                        {
                            Id = new Guid("def79ab8-d35f-4cbc-9787-b78ee5fabd1f"),
                            MaxWeight = 125.0,
                            MinWeight = 115.0,
                            Name = "Flyweight"
                        },
                        new
                        {
                            Id = new Guid("6309f412-c5d0-4020-8a90-b7fcc678ff8f"),
                            MaxWeight = 135.0,
                            MinWeight = 125.0,
                            Name = "Bantamweight"
                        },
                        new
                        {
                            Id = new Guid("feba3733-4e9c-4309-954a-66616afded74"),
                            MaxWeight = 145.0,
                            MinWeight = 135.0,
                            Name = "Featherweight"
                        },
                        new
                        {
                            Id = new Guid("829e0070-5a08-4a0d-bcf0-3f2505f02009"),
                            MaxWeight = 155.0,
                            MinWeight = 145.0,
                            Name = "Lightweight"
                        },
                        new
                        {
                            Id = new Guid("a58ed655-4395-41b7-be26-ad8fe3ecc1e4"),
                            MaxWeight = 170.0,
                            MinWeight = 155.0,
                            Name = "Welterweight"
                        },
                        new
                        {
                            Id = new Guid("03dd8f57-3c3c-4e3c-b0d1-54613b6cad68"),
                            MaxWeight = 185.0,
                            MinWeight = 170.0,
                            Name = "Middleweight"
                        },
                        new
                        {
                            Id = new Guid("43b57e8f-44bd-4420-911f-f15f282287e3"),
                            MaxWeight = 205.0,
                            MinWeight = 185.0,
                            Name = "Light Heavyweight"
                        },
                        new
                        {
                            Id = new Guid("345d657d-9f6d-489f-81ad-7c2b23dbca85"),
                            MaxWeight = 265.0,
                            MinWeight = 205.0,
                            Name = "Heavyweight"
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

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasComment("this is a bool that keeps track of the status of the fight- deleted or not (soft delete)");

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

                    b.HasData(
                        new
                        {
                            Id = new Guid("79d85fe7-6bda-4390-becc-921714e46af0"),
                            DateOfTheFight = new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A legendary UFC fight between two icons of the sport.",
                            ImageUrl = "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg",
                            IsDeleted = false,
                            PublisherId = "51ac4bdd-94b1-4555-bb6e-382c55dd0c49",
                            Title = "Conor McGregor vs Khabib Nurmagomedov"
                        },
                        new
                        {
                            Id = new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca"),
                            DateOfTheFight = new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A thrilling bout between two fierce rivals.",
                            ImageUrl = "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg",
                            IsDeleted = false,
                            PublisherId = "51ac4bdd-94b1-4555-bb6e-382c55dd0c49",
                            Title = "Israel Adesanya vs Alex Pereira"
                        },
                        new
                        {
                            Id = new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87"),
                            DateOfTheFight = new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A classic middleweight bout filled with drama.",
                            ImageUrl = "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg",
                            IsDeleted = false,
                            PublisherId = "51ac4bdd-94b1-4555-bb6e-382c55dd0c49",
                            Title = "Anderson Silva vs Chael Sonnen"
                        });
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

                    b.HasData(
                        new
                        {
                            FighterId = new Guid("4bff9e8a-5832-4c7a-b9a0-c0a94b801415"),
                            FightId = new Guid("79d85fe7-6bda-4390-becc-921714e46af0")
                        },
                        new
                        {
                            FighterId = new Guid("1550013c-e044-4f0e-a337-3bfbde73f510"),
                            FightId = new Guid("79d85fe7-6bda-4390-becc-921714e46af0")
                        },
                        new
                        {
                            FighterId = new Guid("500391a5-d4ba-4f6e-8b35-880f75398eef"),
                            FightId = new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca")
                        },
                        new
                        {
                            FighterId = new Guid("67de9f12-8221-42f2-9474-b89953651748"),
                            FightId = new Guid("3d2dc79b-2398-421e-b9bc-15cf1c29f4ca")
                        },
                        new
                        {
                            FighterId = new Guid("6301e156-7b95-4a58-b3e9-aee197bcfdf1"),
                            FightId = new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87")
                        },
                        new
                        {
                            FighterId = new Guid("0093a69e-632f-4934-bf45-23235ad134db"),
                            FightId = new Guid("ef939acd-47bb-4ac7-b915-d237ad5f8c87")
                        });
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

            modelBuilder.Entity("Fighter", b =>
                {
                    b.HasOne("SportsEventsApp.Data.Category", "Category")
                        .WithMany("Fighters")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
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

            modelBuilder.Entity("SportsEventsApp.Data.FighterFight", b =>
                {
                    b.HasOne("SportsEventsApp.Data.Fight", "Fight")
                        .WithMany("FighterFights")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fighter", "Fighter")
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