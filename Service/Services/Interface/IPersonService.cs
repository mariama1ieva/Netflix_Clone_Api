using Service.DTOs.Person;

namespace Service.Services.Interface
{
    public interface IPersonService
    {
        Task CreateAsync(PersonCreateDto person);
        Task<IEnumerable<GetPeopleDto>> GetALlPeople();
        Task<GetPeopleDto> GetByIdAsync(int id);
        //Task<Plan> DeletePlanAsync(int id);
        //Task<PlanEditDto> UpdatePlanEditAsync(PlanEditDto plan);
    }
}
