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
    public class BookController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            return Ok("Success");
        }

        [HttpGet]
        public IActionResult RetrieveBooks()
        {
            return Ok(new List<Book>());
        }

        [HttpGet]
        [Route("{bookid}")]
        public IActionResult RetrieveBook(int bookid)
        {
            return Ok(new Book());
        }

        [HttpPut]
        [Route("{bookid}")]
        public IActionResult UpdateBook(Book book, int bookid)
        {
            return Ok("Success");
        }

        [HttpDelete]
        [Route("{bookid}")]
        public IActionResult DeleteBook(int bookid)
        {
            return Ok("Success");
        }
    }
}