using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class ContentPerson : BaseEntity
    {
        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; }

        public string RoleDescription { get; set; }
    }
}
