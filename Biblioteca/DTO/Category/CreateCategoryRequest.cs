using System.ComponentModel.DataAnnotations;

namespace Biblioteca.DTO.Category
{
    public class CreateCategoryRequest
    {
        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "Category name must be between 1 and 100 characters.")]
        public string? CategoryName { get; set; }
    }
}
