namespace Biblioteca.Models.DTO.Books
{
    public class UpdateBookRequest
    {
        public string? Title { get; set; }
        public int? CategoryId { get; set; }
        public DateOnly? PublicationDate { get; set; }
        public int? CopiesOwned { get; set; }
        public virtual Category? Category { get; set; }
    }
}
