using System.Collections.Generic;

namespace SimpleDuelApi.Models
{
    public class PlanetListDetailDto
    {
        public string Name { get; set; }
        public List<EnhancedBeingPlanetListDto> BeingsFromPlanet { get; set; }         
    }
    public class EnhancedBeingPlanetListDto
    {
        public string Name { get; set; }
    }
}