using Biblioteca.DTO.Authors;

namespace Biblioteca.Services.Author
{
    public interface IAuthorService
    {
        AuthorDTO CreateAuthor(CreateAuthorRequest request);
        AuthorDTO ReadAuthor(String id);
        AuthorDTO UpdateAuthor(String id, UpdateAuthorRequest request);
        AuthorDTO DeleteAuthor(String id);

    }
}
