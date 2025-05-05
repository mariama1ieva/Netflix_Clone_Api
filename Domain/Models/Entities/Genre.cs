using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class Genre : BaseEntity
    {
        public string? Name { get; set; }

        public ICollection<ContentGenre>? ContentGenres { get; set; }
    }
}
