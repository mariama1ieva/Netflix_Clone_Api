using Domain.Models.Entities;
using Netflix.Repository.DAL;
using Netflix.Repository.Repositories;
using Repository.Repositories.Interface;

namespace Repository.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(AppDbContext context) : base(context)
        {
        }
    }
}
