using Netflix.Domain.Models.Common;
using Netflix.Domain.Models.Entities;

namespace Domain.Models.Entities
{
    public class Content : BaseEntity
    {
        public string? Title { get; set; }
        public string? Type { get; set; } // "Movie" or "Series"
        public int ReleaseYear { get; set; }
        public string? Description { get; set; }
        public string? Rating { get; set; }

        public ICollection<ContentGenre>? ContentGenres { get; set; }
        public ICollection<ContentPerson>? ContentPeople { get; set; }
        public ICollection<Episode>? Episodes { get; set; }
    }
}
