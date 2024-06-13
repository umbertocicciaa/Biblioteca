using Biblioteca.DTO.Authors;

namespace Biblioteca.Services.Author
{
    public interface IAuthorService
    {
        AuthorDTO CreateAuthor(CreateAuthorRequest request);
        AuthorDTO ReadAuthor(string id);
        AuthorDTO UpdateAuthor(string id, UpdateAuthorRequest request);
        DeleteAuthorResponse DeleteAuthor(string id);

    }
}
