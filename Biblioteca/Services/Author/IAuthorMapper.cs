using Biblioteca.DTO.Authors;

namespace Biblioteca.Services.Author
{
    public interface IAuthorMapper
    {
        AuthorDTO ToAuthorDTO(Models.Author authorToAdd);
        Models.Author ToAuthorEntity(CreateAuthorRequest createAuthorRequest);
    }
}
