﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsEventsApp.Data;

#nullable disable

namespace SportsEventsApp.Data.Migrations
{
    [DbContext(typeof(SportEventsAppDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .HasComment("The height of the fighter in cm");

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
                        .HasComment("The fighter's reach in centimeters");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Fighters");
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
                            Id = "93a2d891-447d-4e86-a35f-ed0545fe13e8",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0b3fb9ab-4cd6-4aca-87e7-1dab7a69fd32",
                            Email = "admin@mma.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MMA.COM",
                            NormalizedUserName = "ADMIN@MMA.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKsc1MBAfS50I6EAELOQoZeoEI63PtAxRvPl6ZnhOLnets/GmpbEzx15/UwwORYdEw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fecc147c-29e7-4322-b165-da2d9a051e71",
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
                            Id = new Guid("7eb59926-fda7-4142-bcb6-bcc22a6caf08"),
                            MaxWeight = 115.0,
                            MinWeight = 106.0,
                            Name = "Strawweight"
                        },
                        new
                        {
                            Id = new Guid("8a6c7bd5-1813-4565-a9b6-66bd3d44c424"),
                            MaxWeight = 125.0,
                            MinWeight = 115.0,
                            Name = "Flyweight "
                        },
                        new
                        {
                            Id = new Guid("9e406232-4fe0-4acd-afa5-0f16c213cb09"),
                            MaxWeight = 135.0,
                            MinWeight = 125.0,
                            Name = "Bantamweight  "
                        },
                        new
                        {
                            Id = new Guid("0beb008a-477c-44e1-bb0e-9eea422f6234"),
                            MaxWeight = 145.0,
                            MinWeight = 135.0,
                            Name = "Featherweight  "
                        },
                        new
                        {
                            Id = new Guid("272abaaa-1fee-4b96-9ef1-29c951bd5df7"),
                            MaxWeight = 155.0,
                            MinWeight = 145.0,
                            Name = "Lightweight "
                        },
                        new
                        {
                            Id = new Guid("4af344c1-dcf2-4ba2-a2a9-0bfe76b07aea"),
                            MaxWeight = 170.0,
                            MinWeight = 155.0,
                            Name = "Welterweight  "
                        },
                        new
                        {
                            Id = new Guid("a9c5d524-dd66-417c-8971-6cdee181860c"),
                            MaxWeight = 185.0,
                            MinWeight = 170.0,
                            Name = "Middleweight  "
                        },
                        new
                        {
                            Id = new Guid("157b6b64-9276-4f92-a460-869ec1985a72"),
                            MaxWeight = 205.0,
                            MinWeight = 185.0,
                            Name = "Light heavyweight "
                        },
                        new
                        {
                            Id = new Guid("e4608da9-bae7-41dd-8ead-50fa72561d7e"),
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
                            Id = new Guid("a5aac695-ebbd-45a8-bdd7-a65b3c315b80"),
                            DateOfTheFight = new DateTime(2018, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A legendary UFC fight between two icons of the sport.",
                            ImageUrl = "https://i.ytimg.com/vi/JuBBIJ7adjM/hq720.jpg",
                            IsDeleted = false,
                            PublisherId = "93a2d891-447d-4e86-a35f-ed0545fe13e8",
                            Title = "Conor McGregor vs Khabib Nurmagomedov"
                        },
                        new
                        {
                            Id = new Guid("284917e7-8e31-44be-bfd6-116507d1bcaa"),
                            DateOfTheFight = new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A thrilling bout between two fierce rivals.",
                            ImageUrl = "https://www.bet-experts.com/wp-content/uploads/2023/04/ufc-287-bet-experts.jpg",
                            IsDeleted = false,
                            PublisherId = "93a2d891-447d-4e86-a35f-ed0545fe13e8",
                            Title = "Israel Adesanya vs Alex Pereira"
                        },
                        new
                        {
                            Id = new Guid("be58cebf-849a-4ad6-bc18-756e6f210b5c"),
                            DateOfTheFight = new DateTime(2012, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A classic middleweight bout filled with drama.",
                            ImageUrl = "https://i.ytimg.com/vi/ugQCRH9f5QU/maxresdefault.jpg",
                            IsDeleted = false,
                            PublisherId = "93a2d891-447d-4e86-a35f-ed0545fe13e8",
                            Title = "Anderson Silva vs Chael Sonnen"
                        },
                        new
                        {
                            Id = new Guid("f555304d-d67a-40e4-8d7e-5dba746c0292"),
                            DateOfTheFight = new DateTime(2021, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A heavyweight clash for the championship title.",
                            ImageUrl = "https://i.pinimg.com/736x/5e/69/ee/5e69ee1c4c9f20167f124387b2116c3a.jpg",
                            IsDeleted = false,
                            PublisherId = "93a2d891-447d-4e86-a35f-ed0545fe13e8",
                            Title = "Francis Ngannou vs Stipe Miocic"
                        },
                        new
                        {
                            Id = new Guid("99a36ce7-1fee-4c6b-a8e1-34277ee1c9a1"),
                            DateOfTheFight = new DateTime(2018, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "A historic fight in women's MMA.",
                            ImageUrl = "https://mmajunkie.usatoday.com/wp-content/uploads/sites/91/2018/11/cris-cyborg-amanda-nunes-ufc-230-press-conference-1.jpg?w=1000",
                            IsDeleted = false,
                            PublisherId = "93a2d891-447d-4e86-a35f-ed0545fe13e8",
                            Title = "Amanda Nunes vs Cris Cyborg"
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
