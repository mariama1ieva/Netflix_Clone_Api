using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class Episode : BaseEntity
    {
        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int SeasonNumber { get; set; }
        public int EpisodeNumber { get; set; }
        public string Title { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
