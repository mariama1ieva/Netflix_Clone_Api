using Domain.Models.Entities;
using Service.DTOs.Person;

namespace Service.Services.Interface
{
    public interface IPersonService
    {
        Task CreateAsync(PersonCreateDto person);
        Task<IEnumerable<GetPeopleDto>> GetAllPeople();
        Task<GetPeopleDto> GetByIdAsync(int id);
        Task<Person> DeletePersonAsync(int id);
        Task<PersonEditDto> UpdatePersonAsync(PersonEditDto person);
    }
}
