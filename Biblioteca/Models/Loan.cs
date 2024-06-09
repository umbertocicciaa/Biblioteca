using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Loan
{
    public int Id { get; set; }

    public int? MemberId { get; set; }

    public int? BookId { get; set; }

    public DateOnly? LoanDate { get; set; }

    public DateOnly? ReturnedDate { get; set; }

    public virtual Book? Book { get; set; }

    public virtual ICollection<Fine> Fines { get; set; } = new List<Fine>();

    public virtual Member? Member { get; set; }
}
