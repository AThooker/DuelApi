using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Models
{
    public class PlanetCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}