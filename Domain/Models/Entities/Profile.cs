using Domain.Models.Entities;
using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class Profile : BaseEntity
    {
        public string? Name { get; set; }
        public int AgeRating { get; set; }
        public int UserId { get; set; }

        public AppUser? AppUser { get; set; }
    }
}
