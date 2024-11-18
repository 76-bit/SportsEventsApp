using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
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
        public string Title { get; set; }

        [Required]
        [Comment("A brief decription of the fight details, also has a minimum and maximum characher limit")]
        [MinLength(minFightDescLenght)]
        [MaxLength(maxFightDescLenght)]
        public string Description { get; set; }

        [Required]
        [Comment("The date of the fight, not the date of its adding")]
        public DateTime Date { get; set; }

        [Comment("A collection for the two (or maybe more, if it is a special event) fighters in the fight.")]
        public List<Fighter> Fighters { get; set; } = new List<Fighter>();

    }
}
