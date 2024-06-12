namespace Biblioteca.Models;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? CategoryId { get; set; }

    public DateOnly? PublicationDate { get; set; }

    public int? CopiesOwned { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();

    public virtual ICollection<Author> Authors { get; set; } = new List<Author>();
}
