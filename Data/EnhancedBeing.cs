using System.Collections.Generic;

namespace SimpleDuelApi.Data
{
    public abstract class EnhancedBeing
    {
        public string Name { get; set; }
        // public List<Power> Powers { get; set; }
        // public List<Weakness> Weak { get; set; }
        public int PowerLevel { get; set; }
        #nullable enable
        public int? Wins { get; set; }
        #nullable enable
        public int? Losses { get; set; }
        // public List<Hero> HeroesFought { get; set; }
        // public List<Villian> VilliansFought { get; set; }
        public abstract void LevelUp();
        public abstract void LevelDown();
    }
}