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
        public int Id { get; set; }
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

        [Comment("A collection for the two (or maybe more, if it is a special event) fighters in the fight.")]
        public List<Fighter> Fighters { get; set; } = new List<Fighter>();

        [Required]
        [Comment("The id of the admin that added the fight, note that users and guests cannot add or delete fights")]
        public string PublisherId { get; set; } = null!;

        [ForeignKey(nameof(PublisherId))]
        public IdentityUser Publisher { get; set; } = null!;

        [Comment("This is the collection that keeps the fights of the individual user's fight wathclist")]
        public List<UserFight> UsersFights { get; set; } = new List<UserFight>();


    }
}
