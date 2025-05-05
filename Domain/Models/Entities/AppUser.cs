
using Netflix.Domain.Models.Entities;

namespace Domain.Models.Entities
{
    public class AppUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string? Name { get; set; }
        public override string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime SignUpDate { get; set; }
        public int PlanId { get; set; }
        public Plan? Plan { get; set; }
    }
}
