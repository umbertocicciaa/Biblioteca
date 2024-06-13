using Biblioteca.DTO.Authors;
using Biblioteca.Models;
using Biblioteca.Repository;

namespace Biblioteca.Services.Author
{
    public class AuthorService(IAuthorMapper mapper) : IAuthorService
    {
        public IAuthorMapper _mapper = mapper;

        public AuthorDTO CreateAuthor(CreateAuthorRequest request)
        {
            try
            {
                using var context = new LibraryDbContext();
                var authorToAdd = _mapper.ToAuthorEntity(request);
                context.Add(authorToAdd);
                context.SaveChanges();
                return _mapper.ToAuthorDTO(authorToAdd);
            }
            catch (Exception)
            {
                throw new Exceptions.Authors.CantAddAuthorException();
            }
        }

        public AuthorDTO ReadAuthor(string id)
        {
            throw new NotImplementedException();
        }

        public AuthorDTO UpdateAuthor(string id, UpdateAuthorRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteAuthorResponse DeleteAuthor(string id)
        {
            throw new NotImplementedException();
        }
    }
}