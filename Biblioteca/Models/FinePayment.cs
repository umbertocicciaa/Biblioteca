using System;
using System.Collections.Generic;

namespace Biblioteca.Models;

public partial class FinePayment
{
    public int Id { get; set; }

    public int? MemberId { get; set; }

    public DateOnly? PaymentDate { get; set; }

    public decimal? PaymentAmount { get; set; }

    public virtual Member? Member { get; set; }
}
