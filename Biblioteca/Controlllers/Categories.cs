using Biblioteca.DTO.Category;
using Biblioteca.Services.Category;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Categories : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public Categories(ICategoryService categoryService) => _categoryService = categoryService;

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryRequest request)
        {
            var response = this._categoryService.CreateCategory(request);
            return CreatedAtAction(nameof(ReadCategory), new { id = response.Id }, response);
        }

        [HttpGet("{id}")]
        public IActionResult ReadCategory(int id)
        {
            var response = this._categoryService.ReadCategory(id);
            if (response == null)
                return NotFound();
            return Ok(response);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, UpdateCategoryRequest request)
        {
            var updatedCategory = _categoryService.UpdateCategory(id, request);
            if (updatedCategory == null)
                return NotFound();
            return Ok(updatedCategory);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var deleted = _categoryService.DeleteCategory(id);
            if (deleted.Success)
                return Ok(deleted);
            return NotFound(deleted);
        }
    }
}
