namespace Netflix.Domain.Models.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public int IsMain { get; set; }
    }
}
