using Biblioteca.DTO.Authors;

namespace Biblioteca.Services.Author
{
    public class AuthorMapper : IAuthorMapper
    {
        public AuthorDTO ToAuthorDTO(Models.Author authorToAdd)
        {
            var authorDTO = new AuthorDTO
            {
                Id = authorToAdd.Id,

                CodiceFiscale = authorToAdd.CodiceFiscale,

                FirstName = authorToAdd.FirstName,

                LastName = authorToAdd.LastName
            };
            return authorDTO;

        }

        public Models.Author ToAuthorEntity(CreateAuthorRequest createAuthorRequest)
        {
            var author = new Models.Author
            {
                Id = createAuthorRequest.Id,

                CodiceFiscale = createAuthorRequest.CodiceFiscale,

                FirstName = createAuthorRequest.FirstName,

                LastName = createAuthorRequest.LastName

            };
            return author;
        }
    }
}
