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
    public class Test1Controller : ControllerBase
    {
        #region Create
        [HttpPost]
        [Route("Book")]
        public IActionResult CreateBook(Book book)
        {
            return Ok("Success");
        }

        #endregion

        #region Retrieve
        [HttpGet]
        [Route("Book")]
        public IActionResult GetBooks()
        {
            return Ok(new List<Book>());
        }
        [HttpGet]
        [Route("Book/{bookid}")]
        public IActionResult GetBook(int bookid)
        {
            return Ok(new Book());
        }
        #endregion

        #region Update

        [HttpPut]
        [Route("Book/{bookid}")]
        public IActionResult UpdateBook(Book book, int bookid)
        {
            return Ok("Success");
        }
        #endregion

        #region Delete
        [HttpDelete]
        [Route("Book/{bookid}")]
        public IActionResult DeleteBook(int bookid)
        {
            return Ok("Success");
        }
        #endregion
    }
}