using LeagueQuiz.Data.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace LeagueQuiz.Data.Entities
{
    public class Champion
    {
        public Champion()
        {
            this.Abilities = new HashSet<Ability>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [MaxLength(50)]
        public string? Description { get; set; }

        [Required, Url]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public Position Position { get; set; }

        [Required]
        public PlaystyleClass Class { get; set; }

        [Required, Range(450, 6300)]
        public int PriceBE { get; set; }

        [Required, Range(260, 975)]
        public int PriceRP { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public bool HasMana { get; set; }

        [Required]
        public bool IsRanged { get; set; }

        public ICollection<Ability> Abilities { get; set; }
    }
}
