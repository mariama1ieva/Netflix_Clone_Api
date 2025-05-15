using AutoMapper;
using Domain.Models.Entities;
using Repository.Repositories.Interface;
using Service.DTOs.Person;
using Service.Services.Interface;

namespace Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repo;
        private readonly IMapper _mapper;

        public PersonService(IPersonRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }



        public async Task CreateAsync(PersonCreateDto person)
        {
            var entity = _mapper.Map<Person>(person);
            await _repo.CreateAsync(entity);
        }

        public async Task<IEnumerable<GetPeopleDto>> GetALlPeople()
        {
            return _mapper.Map<IEnumerable<GetPeopleDto>>(await _repo.GetAllAsync());

        }

        public async Task<GetPeopleDto> GetByIdAsync(int id)
        {
            return _mapper.Map<GetPeopleDto>(await _repo.GetByIdAsync(id));
        }
    }
}
