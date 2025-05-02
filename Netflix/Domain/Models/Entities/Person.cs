using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Role { get; set; } // "Actor", "Director", etc.

        public ICollection<ContentPerson> ContentPeople { get; set; }
    }
}
