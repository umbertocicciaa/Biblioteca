using Biblioteca.Models;
using Biblioteca.Models.DTO.Books;

namespace Biblioteca.Services.Book
{
    public class BookMapper : IBookMapper
    {
        public Models.DTO.Books.BookDTO ToBookDTO(Models.Book bookToAdd)
        {
            var bookdDto = new Models.DTO.Books.BookDTO();
            bookdDto.Id = bookToAdd.Id;
            bookdDto.CategoryId = bookToAdd.CategoryId;
            bookdDto.PublicationDate = bookToAdd.PublicationDate;
            bookdDto.CopiesOwned = bookToAdd.CopiesOwned;
            bookdDto.Title = bookToAdd.Title;
            return bookdDto;
        }

        public Models.Book ToBookEntity(Models.DTO.Books.CreateBookRequest request)
        {
            var book = new Models.Book();
            book.CategoryId = request.CategoryId;
            book.PublicationDate = request.PublicationDate;
            book.CopiesOwned = request.CopiesOwned;
            book.Title = request.Title;
            return book;
        }
    }
}
