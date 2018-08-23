using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PersonDataAPI.Interfaces;
using PersonDataAPI.Models;

namespace PersonDataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IPersonRepository repository;

        public ValuesController(IPersonRepository repo)
        {
            repository = repo;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new JsonResult(repository.Persons.AsEnumerable());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            
            //string json = JsonConvert.SerializeObject(repository.FindById(id), Formatting.Indented);
            return new JsonResult(repository.FindById(id));
        }

        // POST api/values
        [HttpPost]
        public ActionResult AddPerson([FromForm] Person newPerson)
        {
            repository.Add(newPerson);
            return new JsonResult(newPerson);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
