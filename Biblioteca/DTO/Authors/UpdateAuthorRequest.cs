namespace Biblioteca.DTO.Authors
{
    public class UpdateAuthorRequest
    {
        public int Id { get; set; }

        public string? CodiceFiscale { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}
