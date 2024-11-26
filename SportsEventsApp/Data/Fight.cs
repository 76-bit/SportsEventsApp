using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SportsEventsApp.Constants.ModelConstants;

namespace SportsEventsApp.Data
{
    public class Fight
    {
        [Key]
        [Comment("Unique identifier of the fight")]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Comment("The name of the title, has a minimum and maximum characher limit")]
        [MinLength(minFightTitleLenght)]
        [MaxLength(maxFightTitleLenght)]
        public string Title { get; set; } = null!;

        [Required]
        [Comment("A brief decription of the fight details, also has a minimum and maximum characher limit")]
        [MinLength(minFightDescLenght)]
        [MaxLength(maxFightDescLenght)]
        public string Description { get; set; } = null!;

        [Comment("url of the image")]
        public string? ImageUrl { get; set; }

        [Required]
        [Comment("The date of the fight, not the date of its adding")]
        public DateTime DateOfTheFight { get; set; }

        [Comment("This is the collection that keeps track of the fighters in the fight.")]
        public ICollection<FighterFight> FighterFights { get; set; } = new List<FighterFight>();

        [Required]
        [Comment("The id of the admin that added the fight, note that users and guests cannot add or delete fights")]
        public string PublisherId { get; set; } = null!;

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        [Comment("This is the collection that keeps the fights of the individual user's fight wathclist")]
        public List<UserFight> UsersFights { get; set; } = new List<UserFight>();


    }
}
