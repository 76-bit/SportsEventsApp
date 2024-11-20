using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static SportsEventsApp.Constants.ModelConstants;

namespace SportsEventsApp.Data
{
    public class Fighter
    {
        [Key]
        [Comment("The unique identifier of the fighter")]
        public int Id { get; set; }

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

        [Required]
        [Range(minFighterAge,maxFighterAge)]
        [Comment("The age of the fighter, must be between 18 and 100")]
        public int Age { get; set; }

        [Required]
        [Comment("The height of the fighter in cm")]
        public double Height { get; set; }

        [Required]
        [Comment("The weight class (category) of the fighter")]
        public Category Category { get; set; } = null!;
    }
}