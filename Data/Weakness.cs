using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Data
{
    public class Weakness
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Hero> Heroes { get; set; } = new List<Hero>();
        public List<Villian> Villians { get; set; } = new List<Villian>();
        //possibly add property to contain how strong the weakness is -- i.e. if exposed to weakness, how much is the being affected??
        //maybe something like this: property name Weakness of type int, if exposed to weakness, the power level of whom exposed the weakness affects the power level of 
        //whomever's weakness it is in a manner consistent with their own power level...clear up syntax here
    }
}