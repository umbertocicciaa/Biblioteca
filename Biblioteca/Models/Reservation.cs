using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Reservation
{
    public int Id { get; set; }

    public int? BookId { get; set; }

    public int? MemberId { get; set; }

    public DateOnly? ReservationDate { get; set; }

    public string? ReservationStatus { get; set; }

    public virtual Book? Book { get; set; }

    public virtual Member? Member { get; set; }
}
