using Microsoft.AspNetCore.Mvc;
using MyFirstAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        // Temporary in-memory list (just like a local DB)
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "Clean Code", Author = "Robert C. Martin" },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andrew Hunt" }
        };

        // GET: api/books 
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
            return Ok(books);
        }

        // GET: api/books/1
        [HttpGet("{id}")]
        public ActionResult<Book> GetById(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();
            return Ok(book);
        }

        // POST: api/books
        [HttpPost]
        public ActionResult<Book> Create(Book newBook)
        {
            newBook.Id = books.Count + 1;
            books.Add(newBook);
            return CreatedAtAction(nameof(GetById), new { id = newBook.Id }, newBook);
        }
    }
}
