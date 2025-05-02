using Netflix.Domain.Models.Entities;
using Netflix.Repository.DAL;
using Netflix.Repository.Repositories.Interface;

namespace Netflix.Repository.Repositories
{
    public class PlanRepository : BaseRepository<Plan>, IPlanRepository
    {
        public PlanRepository(AppDbContext context) : base(context) { }
    }
}
