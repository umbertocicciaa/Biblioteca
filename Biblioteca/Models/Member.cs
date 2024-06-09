using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Member
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? CodiceFicale { get; set; }

    public DateOnly? JoinedDate { get; set; }

    public virtual ICollection<FinePayment> FinePayments { get; set; } = new List<FinePayment>();

    public virtual ICollection<Fine> Fines { get; set; } = new List<Fine>();

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();

    public virtual ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
