using Netflix.Service.DTOs.Plan;

namespace Service.Services.Interface
{
    public interface IPlanService
    {
        Task CreateAsync(PlanCreateDto plan);
    }
}
