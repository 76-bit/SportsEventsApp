using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SportsEventsApp.Constants.ModelConstants;

namespace SportsEventsApp.Data
{
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

        [Required]
        [Comment("The age of the figher ( dinamically calculated)")]
        public int Age => DateTime.Now.Year - DateOfBirth.Year;

        [Required]
        [Comment("The height of the fighter in cm")]
        public double Height { get; set; }

        [Required]
        [Comment("The weight class (category) of the fighter")]
        public Guid CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}