namespace SimpleDuelApi.Data
{
    public class HeroWeaknesses
    {
        public int HeroId { get; set; }
        public Hero Hero { get; set; }
        public int WeaknessId { get; set; }
        public Weakness Weakness { get; set; }
    }
}