using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class Plan : BaseEntity
    {
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int MaxDevices { get; set; }
    }
}
