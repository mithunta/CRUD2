using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD2.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD2.API.Controllers
{
    
    [Route("company/{companyid}/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        //http://localhost/company/1/emplyee
        [HttpGet]
        public IActionResult GetEmployees([FromRoute]int companyid)
        {
            if(companyid == 1)
            {
                return BadRequest("Invalid data");
            }
            return Ok(new List<Employee>()); // THis is just an example. We will getting this from the database
        }

        //http://localhost/company/1/emplyee/1
        [HttpGet]
        [Route("{employeeid}")]
        public IActionResult GetEmployees([FromRoute]int companyid, int employeeid)
        {
            return Ok(new List<Employee>()); // THis is just an example. We will getting this from the database
        }

        [HttpPost]
        public IActionResult CreateEmployee([FromRoute]int companyid, [FromBody] Employee employee)
        {
            return Ok("Success"); // This is just an example
        }

        [HttpPut]
        [Route("{employeeid}")]
        public IActionResult UpdateEmployee([FromRoute]int companyid, int employeeid)
        {
            return Ok("Success"); // This is just an example
        }

        [HttpDelete]
        [Route("{employeeid}")]
        public IActionResult DeleteEmployee([FromRoute]int companyid, int employeeid)
        {
            return Ok("Success"); // This is just an example
        }
    }
}