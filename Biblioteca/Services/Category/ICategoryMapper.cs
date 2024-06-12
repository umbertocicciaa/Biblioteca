using Biblioteca.DTO.Category;

namespace Biblioteca.Services.Category
{
    public interface ICategoryMapper
    {
        Models.Category ToCategoryEntity(CreateCategoryRequest request);
        CategoryDTO ToCategoryDto(Models.Category category);

    }
}
