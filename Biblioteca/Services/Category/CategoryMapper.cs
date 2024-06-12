using Biblioteca.DTO.Category;

namespace Biblioteca.Services.Category
{
    public class CategoryMapper : ICategoryMapper
    {
        public CategoryDTO ToCategoryDto(Models.Category category)
        {
            var categoryDTO = new CategoryDTO()
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
            return categoryDTO;
        }

        public Models.Category ToCategoryEntity(CreateCategoryRequest request)
        {
            var entity = new Models.Category()
            { CategoryName = request.CategoryName };
            return entity;
        }
    }
}
