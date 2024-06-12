using Biblioteca.DTO.Category;

namespace Biblioteca.Services.Category
{
    public interface ICategoryService
    {
        CategoryDTO CreateCategory(CreateCategoryRequest request);
        CategoryDTO ReadCategory(int id);
        CategoryDTO UpdateCategory(int id, UpdateCategoryRequest request);
        DeleteCategoryResponse DeleteCategory(int id);
    }
}