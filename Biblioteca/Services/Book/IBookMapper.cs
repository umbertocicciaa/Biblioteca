using Biblioteca.DTO.Books;

namespace Biblioteca.Services.Book
{
    public interface IBookMapper
    {
        BookDTO ToBookDTO(Models.Book bookToAdd);
        Models.Book ToBookEntity(CreateBookRequest request);
    }
}
