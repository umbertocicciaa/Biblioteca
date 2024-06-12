using Biblioteca.Models.DTO.Authors;

namespace Biblioteca.Services.Author
{
    public interface IAuthorService
    {
        AuthorDTO CreateAuthor(CreateAuthorRequest request);
        AuthorDTO ReadAuthor(String id);
        AuthorDTO UpdateAuthor(String id, UpdateAuthorRequest request);
        DeleteAuthorResponse DeleteAuthor(String id);

    }
}
