using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PersonDataAPI.Models
{
    public class PersonDBContext : DbContext
    {
        public PersonDBContext(DbContextOptions<PersonDBContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        
    }
}
