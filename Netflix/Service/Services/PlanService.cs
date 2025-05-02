using AutoMapper;
using Netflix.Domain.Models.Entities;
using Netflix.Repository.Repositories.Interface;
using Netflix.Service.DTOs.Plan;
using Netflix.Service.Services.Interface;

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
    }
}
