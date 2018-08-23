using System.Linq;
using PersonDataAPI.Models;

namespace PersonDataAPI.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get;}
        void Add(Person newperson);
        Person FindById(int id);
        void Delete(int id);
    }
}
