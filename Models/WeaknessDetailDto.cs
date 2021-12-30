namespace SimpleDuelApi.Models
{
    //used for get list and get by id methods
    public class WeaknessDetailDto
    {
        public string Name { get; set; }
        //# of heroes with this power
        public int HeroCount { get; set; }
        //# of villians with this power
        public int VillianCount { get; set; }
    }
}