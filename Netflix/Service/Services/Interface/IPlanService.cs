using Netflix.Service.DTOs.Plan;

namespace Netflix.Service.Services.Interface
{
    public interface IPlanService
    {
        Task CreateAsync(PlanCreateDto plan);
    }
}
