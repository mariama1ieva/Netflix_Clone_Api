using Domain.Models.Entities;
using Netflix.Domain.Models.Entities;
using Netflix.Service.DTOs.Plan;
using Service.DTOs.Person;
using Service.DTOs.Plan;


namespace Service.Helpers
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            CreateMap<PlanCreateDto, Plan>();
            CreateMap<Plan, GetPlanDto>();
            CreateMap<Plan, PlanEditDto>();
            CreateMap<PlanEditDto, Plan>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());


            CreateMap<PersonCreateDto, Person>();
            CreateMap<Person, GetPeopleDto>();
            CreateMap<Person, PersonEditDto>();
            CreateMap<PersonEditDto, Person>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
        }
    }
}
