using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SportsEventsApp.Data
{
    public class Category
    {
        [Key]
        [Comment("The id of the category")]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        [Comment("The name of the category, exemple: LightWeight, MiddleWeight....")]
        public string Name { get; set; } = null!;

        [Required]
        [Comment("The minimum required weight needed to clasify as this weight, in pounds.")]
        public double MinWeight { get; set; }

        [Required]

        [Comment("The minimum required weight needed to clasify as this weight, in pounds.")]
        public double MaxWeight { get; set; }

        [Comment("A collection that keeps track of all the fighter with a sspecific category")]
        public IList<Fighter> Fighters { get; set; } = new List<Fighter>(); 
    }
}