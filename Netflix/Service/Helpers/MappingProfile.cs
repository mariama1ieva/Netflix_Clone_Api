using Netflix.Domain.Models.Entities;
using Netflix.Service.DTOs.Plan;


namespace Netflix.Service.Helpers
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<PlanCreateDto, Plan>();
        }
    }
}
