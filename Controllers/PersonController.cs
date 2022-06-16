using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        SqlReader reader { get; set; }
        public PersonController(SqlReader sqlReader)
        {
            reader = sqlReader;
        }

        [Route("/names/")]
        [HttpGet]
        public async Task<List<Name>> GetAllNames()
        {
           var people =  await reader.GetPeople();
           var names = new List<Name>();
           foreach(var person in people)
           {
                names.Add(new Name { FirstName = person.FirstName, LastName = person.LastName });
           }
            return names;
        }
        public async Task<IEnumerable<Person>> Get()
        {
            return await reader.GetPeople();
        }      
    }
}
