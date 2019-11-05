using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD2.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD2.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        
        #region Create
        //http://localhost:4478/company (This will add a new company, because we are using POST. 
        [HttpPost]
        public IActionResult AddCompany([FromBody] Company company)
        {
            Console.WriteLine(company.CompanyName + "," + company.CompanyAddress);
            return Ok("Success");
        }
        #endregion

        #region Retrieve
        //http://localhost:44378/company - This will return all the companies (List of Companies)
        [HttpGet]
        public IActionResult GetCompanies()
        {
            return Ok(new List<Company>());
        }

        //http://localhost:4478/company/1 - This will return only 1 company
        [HttpGet]
        [Route("{companyid}")]
        public IActionResult GetCompanies(int companyid)
        {
            return Ok(new Company());
        }
        #endregion

        #region Update
        //http://localhost:4478/company/1 (This will edit/update the company, Body will have the information and with the Id specified in the url)
        [HttpPut]
        [Route("{companyid}")]
        public IActionResult EditCompany([FromBody]Company company, int companyid)
        {
            return Ok("Success");
        }
        #endregion

        #region Delete
        //http://localhost:4478/company/1 (This will remove the company, with the Id specified in the url)
        [HttpDelete]
        [Route("{companyid}")]
        public IActionResult DeleteCompany(int companyid)
        {
            return Ok("Success");
        }
        #endregion
    }
}