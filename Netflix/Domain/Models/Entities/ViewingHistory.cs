using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class ViewingHistory : BaseEntity
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }

        public DateTime WatchDate { get; set; }
        public TimeSpan DurationWatched { get; set; }
    }
}
