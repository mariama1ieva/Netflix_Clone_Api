using AutoMapper;
using Netflix.Domain.Models.Entities;
using Netflix.Repository.Repositories.Interface;
using Netflix.Service.DTOs.Plan;
using Service.DTOs.Plan;
using Service.Services.Interface;

namespace Netflix.Service.Services
{
    public class PlanService : IPlanService
    {
        public readonly IPlanRepository _repo;
        public readonly IMapper _mapper;

        public PlanService(IPlanRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task CreateAsync(PlanCreateDto plan)
        {
            var entity = _mapper.Map<Plan>(plan);
            await _repo.CreateAsync(entity);
        }



        public async Task<IEnumerable<GetPlanDto>> GetAllPlans()
        {
            return _mapper.Map<IEnumerable<GetPlanDto>>(await _repo.GetAllAsync());
        }


        public async Task<GetPlanDto> GetByIdAsync(int id)
        {
            return _mapper.Map<GetPlanDto>(await _repo.GetByIdAsync(id));

        }

        public async Task<Plan> DeletePlanAsync(int id)
        {
            var entity = await _repo.GetByIdAsync(id);
            await _repo.DeleteAsync(entity);
            return _mapper.Map<Plan>(entity);
        }

        public async Task<PlanEditDto> UpdatePlanEditAsync(PlanEditDto plan)
        {
            var entity = await _repo.GetByIdAsync(plan.Id);

            _mapper.Map(plan, entity);
            await _repo.UpdateAsync(entity);

            return _mapper.Map<PlanEditDto>(entity);
        }
    }
}
