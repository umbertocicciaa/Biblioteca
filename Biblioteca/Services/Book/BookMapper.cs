using Biblioteca.DTO.Books;

namespace Biblioteca.Services.Book
{
    public class BookMapper : IBookMapper
    {
        public BookDTO ToBookDTO(Models.Book bookToAdd)
        {
            var bookdDto = new BookDTO
            {
                Id = bookToAdd.Id,
                CategoryId = bookToAdd.CategoryId,
                PublicationDate = bookToAdd.PublicationDate,
                CopiesOwned = bookToAdd.CopiesOwned,
                Title = bookToAdd.Title
            };
            return bookdDto;
        }

        public Models.Book ToBookEntity(CreateBookRequest request)
        {
            var book = new Models.Book
            {
                CategoryId = request.CategoryId,
                PublicationDate = request.PublicationDate,
                CopiesOwned = request.CopiesOwned,
                Title = request.Title
            };
            return book;
        }
    }
}
