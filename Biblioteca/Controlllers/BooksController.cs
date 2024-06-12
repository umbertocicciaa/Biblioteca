using Azure.Core;
using Biblioteca.DTO.Books;
using Biblioteca.Services.Book;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookService _bookService;

        public BooksController(IBookService bookService) => _bookService = bookService;

        [HttpPost]
        public IActionResult CreateBook(CreateBookRequest request)
        {
            var response = this._bookService.CreateBook(request);
            return CreatedAtAction(nameof(ReadBook), new { id = response.Id }, response);
        }
        
        [HttpGet("{id}")]
        public IActionResult ReadBook(string id)
        {
            var response = this._bookService.ReadBook(id);
            if(response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBook(string id,UpdateBookRequest request)
        {
            var updatedBook = _bookService.UpdateBook(id, request);
            if (updatedBook == null)
                return NotFound();
            return Ok(updatedBook);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBook(string id)
        {
            var deleted = _bookService.DeleteBook(id);
            if (deleted.Success)
                return Ok(deleted);
            return NotFound(deleted);
        }
    }
}
