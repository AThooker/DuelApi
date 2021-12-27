using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Data
{
    public class Weakness
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        //scale to 100, strength of this specific power for this specific person
        public int Level { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Villian> Villians { get; set; }    
    }
}