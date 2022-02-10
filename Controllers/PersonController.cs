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
        public async Task<IEnumerable<Person>> Get()
        {
            return await reader.GetPeople();
        }
    }
}
