using Biblioteca.DTO.Authors;
using Biblioteca.Services.Author;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController(IAuthorService authorService) : ControllerBase
    {
        private readonly IAuthorService _authorService = authorService;

        [HttpPost]
        public IActionResult CreateAuthor(CreateAuthorRequest request)
        {
            var response = _authorService.CreateAuthor(request);
            return CreatedAtAction(nameof(ReadAuthor), new { id = response.Id }, response);

        }

        [HttpGet("{id}")]
        public IActionResult ReadAuthor(String id)
        {
            var response = _authorService.ReadAuthor(id);
            if (response == null)
                return NotFound();
            return Ok(response);

        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(String id, UpdateAuthorRequest request)
        {
            var updateAuthor = _authorService.UpdateAuthor(id, request);
            if (updateAuthor == null) return NotFound();
            return Ok(updateAuthor);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(String id)
        {
            var deleted = _authorService.DeleteAuthor(id);
            //if (deleted.Success)
            //  return Ok(deleted);
            return NotFound(deleted);

        }
    }
}
