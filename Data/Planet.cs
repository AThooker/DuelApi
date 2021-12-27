using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Data
{
    public class Planet
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Hero> Heroes { get; set; }
        public List<Villian> Villians { get; set; }
    }
}