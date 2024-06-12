using Biblioteca.DTO.Category;
using Biblioteca.Exceptions.Category;
using Biblioteca.Models;

namespace Biblioteca.Services.Category
{
    public class CategoryService(ICategoryMapper mapper) : ICategoryService
    {

        private readonly ICategoryMapper _mapper=mapper;

        public CategoryDTO CreateCategory(CreateCategoryRequest request)
        {
            try
            {
                using var context = new LibraryDbContext();
                var categoryEntities = _mapper.ToCategoryEntity(request);
                context.Categories.Add(categoryEntities);
                context.SaveChanges();
                return _mapper.ToCategoryDto(categoryEntities);
            }
            catch (Exception) 
            {
                throw new CantAddCategoryException();
            }
        }

        public DeleteCategoryResponse DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO ReadCategory(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDTO UpdateCategory(int id, UpdateCategoryRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
