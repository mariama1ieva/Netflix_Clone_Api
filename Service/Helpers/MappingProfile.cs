using Netflix.Domain.Models.Entities;
using Netflix.Service.DTOs.Plan;


namespace Service.Helpers
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<PlanCreateDto, Plan>();
        }
    }
}
