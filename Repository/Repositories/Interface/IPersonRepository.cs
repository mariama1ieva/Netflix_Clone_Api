using Domain.Models.Entities;
using Netflix.Repository.Repositories.Interface;

namespace Repository.Repositories.Interface
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
    }
}
