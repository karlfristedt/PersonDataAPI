using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonDataAPI.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Namn { get; set; }
        public string Email { get; set; }
    }
}
