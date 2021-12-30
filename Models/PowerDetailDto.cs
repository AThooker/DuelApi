using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Models
{
    //used for get list and get by id methods
    public class PowerDetailDto
    {
        public string Name { get; set; }
        // [Range(1, 100)]
        public int Level { get; set; }
        //# of heroes with this power
        public int HeroCount { get; set; }
        //# of villians with this power
        public int VillianCount { get; set; }
    }
}