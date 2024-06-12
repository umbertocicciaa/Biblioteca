
using Biblioteca.Services.Book;
using Biblioteca.Models;
using Biblioteca.DTO.Books;
namespace Biblioteca.Services
{
    public class BookService : IBookService
    {
   
        private readonly IBookMapper _mapper;

        public BookService(IBookMapper mapper) 
        { 
            _mapper = mapper;
        }

        public BookDTO CreateBook(CreateBookRequest request)
        {
            try
            {
                using (var contex = new LibraryDbContext())
                {
                    var bookToAdd = _mapper.ToBookEntity(request);
                    bookToAdd.PublicationDate = DateOnly.FromDateTime(DateTime.Now);
                    contex.Add(bookToAdd);
                    contex.SaveChanges();
                    return _mapper.ToBookDTO(bookToAdd);
                }
            }
            catch (Exception)
            {
                throw new Exceptions.Books.CantAddBookException();
            }
        }
        public BookDTO ReadBook(string bookId)
        {
            throw new NotImplementedException();
        }
        public BookDTO UpdateBook(string id,UpdateBookRequest request)
        {
            throw new NotImplementedException();
        }
        public DeleteBookResponse DeleteBook(string id)
        {
            throw new NotImplementedException();
        }
    }
}
