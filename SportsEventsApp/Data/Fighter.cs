﻿using Microsoft.EntityFrameworkCore;
using SportsEventsApp.Data;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static SportsEventsApp.Constants.ModelConstants;

public class Fighter
{
    [Key]
    [Comment("The unique identifier of the fighter")]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [MinLength(minFighterFirstNameLenght)]
    [MaxLength(maxFighterFirstNameLenght)]
    [Comment("First name of the fighter")]
    public string FirstName { get; set; } = null!;

    [Required]
    [MinLength(minFighterLastNameLenght)]
    [MaxLength(maxFighterLastNameLenght)]
    [Comment("Last name of the fighter")]
    public string LastName { get; set; } = null!;

    [Required]
    [MinLength(minFighterNickNameLenght)]
    [MaxLength(maxFighterNickNameLenght)]
    [Comment("Nickname of the fighter")]
    public string NickName { get; set; } = null!;

    public DateTime DateOfBirth { get; set; }

    [Comment("The age of the fighter (dynamically calculated)")]
    public int Age => DateTime.Now.Year - DateOfBirth.Year;

    [Required]
    [Comment("The height of the fighter in feet")]
    public double Height { get; set; }

    [Required]
    [Comment("The weight class (category) of the fighter")]
    public Guid CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; } = null!;

    [Range(0, int.MaxValue)]
    [Comment("The fighter's reach in inches")]
    public int Reach { get; set; }

    [Comment("URL for the fighter's image")]
    //Note: the url should not be sitting here. This is temporary
    public string? ImageUrl { get; set; } = "https://static.vecteezy.com/system/resources/thumbnails/020/765/399/small_2x/default-profile-account-unknown-icon-black-silhouette-free-vector.jpg";

    [Required]
    [Comment("The nationality of the fighter")]
    public string Country { get; set; } = null!;

    [NotMapped]
    public string FullName => $"{FirstName} '{NickName}' {LastName}";

    [Comment("Indicates wether the fighter is deleted (soft delete).")]
    public bool IsDeleted { get; set; } = false;

    // Navigation property for FighterFights
    public ICollection<FighterFight> FighterFights { get; set; } = new List<FighterFight>();
}
