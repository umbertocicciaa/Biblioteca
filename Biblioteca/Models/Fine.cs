using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class Fine
{
    public int Id { get; set; }

    public int? MemberId { get; set; }

    public int? LoanId { get; set; }

    public DateOnly? FineDate { get; set; }

    public virtual Loan? Loan { get; set; }

    public virtual Member? Member { get; set; }
}
