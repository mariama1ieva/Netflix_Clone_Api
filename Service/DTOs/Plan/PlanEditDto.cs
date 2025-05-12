

namespace Service.DTOs.Plan
{
    public class PlanEditDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int MaxDevices { get; set; }
    }
}
