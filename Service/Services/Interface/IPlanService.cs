using Netflix.Domain.Models.Entities;
using Netflix.Service.DTOs.Plan;
using Service.DTOs.Plan;

namespace Service.Services.Interface
{
    public interface IPlanService
    {
        Task CreateAsync(PlanCreateDto plan);
        Task<IEnumerable<GetPlanDto>> GetAllPlans();
        Task<GetPlanDto> GetByIdAsync(int id);
        Task<Plan> DeletePlanAsync(int id);
        Task<PlanEditDto> UpdatePlanEditAsync(PlanEditDto plan);

    }
}
