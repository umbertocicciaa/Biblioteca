﻿namespace Biblioteca.DTO.Books
{
    public class UpdateBookRequest
    {
        public string? Title { get; set; }
        public int? CategoryId { get; set; }
        public DateOnly? PublicationDate { get; set; }
        public int? CopiesOwned { get; set; }
    }
}
