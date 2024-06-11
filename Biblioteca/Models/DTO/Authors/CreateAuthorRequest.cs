﻿namespace Biblioteca.Models.DTO.Authors
{
    public class CreateAuthorRequest
    {
        public int Id { get; set; }

        public string? CodiceFiscale { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }
    }
}