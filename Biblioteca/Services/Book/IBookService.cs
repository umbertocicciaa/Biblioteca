using Biblioteca.Models.DTO.Books;

namespace Biblioteca.Services.Book
{
    public interface IBookService
    {
        BookDTO CreateBook(CreateBookRequest request);
        BookDTO ReadBook(string bookId);
        BookDTO UpdateBook(string id, UpdateBookRequest request);
        DeleteBookResponse DeleteBook(string id);
    }
}
