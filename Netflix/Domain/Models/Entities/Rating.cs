using Netflix.Domain.Models.Common;

namespace Netflix.Domain.Models.Entities
{
    public class Rating : BaseEntity
    {
        public int ProfileId { get; set; }
        public Profile Profile { get; set; }

        public int ContentId { get; set; }
        public Content Content { get; set; }

        public int Stars { get; set; }
        public string Review { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
