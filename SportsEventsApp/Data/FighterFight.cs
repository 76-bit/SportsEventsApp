using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportsEventsApp.Data
{
    public class FighterFight
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int FighterId { get; set; }

        [ForeignKey(nameof(FighterId))]
        public Fighter Fighter { get; set; } = null!;

        [Required]
        public int FightId { get; set; }

        [ForeignKey(nameof(FightId))]
        public Fight Fight { get; set; } = null!;
    }
}
