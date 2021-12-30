using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Models
{
    public class EnhancedBeingCreateDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int PowerLevel { get; set; }
        [Required]
        public string PowerName { get; set; }
        public string PowerNameTwo { get; set; }
        [Required]
        public int PlanetId { get; set; }
    }
}