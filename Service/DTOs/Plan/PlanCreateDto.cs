namespace Netflix.Service.DTOs.Plan
{
    public class PlanCreateDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int MaxDevices { get; set; }
    }
}
