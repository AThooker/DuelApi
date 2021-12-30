namespace SimpleDuelApi.Models
{
    public class EnhancedBeingListDto
    {
        public string Name { get; set; }
        public int PowerLevel { get; set; }
        public PowerDetailDto PowerOne { get; set; }
        #nullable enable
        public PowerDetailDto? PowerTwo { get; set; }
        public WeaknessDetailDto WeaknessOne { get; set; }
        #nullable enable
        public WeaknessDetailDto? WeaknessTwo { get; set; }
        public decimal WinPercentage { get; set; }
    }
}