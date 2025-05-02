using Microsoft.AspNetCore.Identity;

namespace Netflix.Domain.Models.Entities
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime SignUpDate { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }
}
