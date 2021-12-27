using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleDuelApi.Data
{
    public class Hero : EnhancedBeing
    {
        [Key]
        public int Id { get; set; }
        public override void LevelDown()
        {
            PowerLevel -= 5;
        }

        public override void LevelUp()
        {
            PowerLevel += 3;
        }
        public ICollection<Power> Powers { get; set; }
        public ICollection<Weakness> Weaknesses { get; set; }
        [ForeignKey(nameof(Planet))]
        public int PlanetId { get; set; }
        public virtual Planet Planet { get; set; }
    }
}