using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class ContentGenre : BaseEntity
    {
        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}

