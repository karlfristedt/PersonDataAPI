using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PersonDataAPI.Interfaces;
using PersonDataAPI.Models;

namespace PersonDataAPI.Respository
{
    public class PersonRepository : IPersonRepository
    {
        private PersonDBContext context;

        public PersonRepository(PersonDBContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Person> Persons => context.Persons;

        public void Add(Person newperson)
        {
            context.Add(newperson);
            context.SaveChanges();
        }

        public Person FindById(int id)
        {
            return context.Persons.FirstOrDefault(x => x.PersonId == id);
        }

        public void Delete(int id)
        {
            var personToBeDeleted = context.Persons.FirstOrDefault(x => x.PersonId == id);
            context.Remove(personToBeDeleted ?? throw new InvalidOperationException());
            context.SaveChanges();
        }
    }
}
