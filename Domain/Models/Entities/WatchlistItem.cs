using Domain.Models.Entities;
using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class WatchlistItem : BaseEntity
    {
        public int ProfileId { get; set; }
        public Profile? Profile { get; set; }
        public int ContentId { get; set; }
        public Content? Content { get; set; }

        public DateTime AddedDate { get; set; }
    }
}
