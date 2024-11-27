using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsEventsApp.Data
{
    [PrimaryKey(nameof(FighterId), nameof(FightId))]
    public class FighterFight
    {
        [Required]
        public Guid FighterId { get; set; }

        [ForeignKey(nameof(FighterId))]
        public Fighter Fighter { get; set; } = null!;

        [Required]
        public Guid FightId { get; set; }

        [ForeignKey(nameof(FightId))]
        public Fight Fight { get; set; } = null!;
    }
}
