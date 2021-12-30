using System.ComponentModel.DataAnnotations;

namespace SimpleDuelApi.Models
{
    public class PowerCreateDto : PowerWeaknessCreateDto
    {
        [Range(1,100)]
        public int PowerLevel { get; set; }
    }
}