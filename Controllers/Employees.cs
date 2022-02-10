using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonProject.Controllers
{
    public class Employees : ControllerBase
    {
        SqlReader reader { get; set; }
        public Employees(SqlReader sqlReader)
        {
            reader = sqlReader;
        }

        [Route("/employees/{WorkPlace}")]
        [HttpGet]
        public async Task<List<Person>> Get(string WorkPlace)
        {
            var res = await reader.GetEmployeees(WorkPlace);
            return res;
        }
    }
}
