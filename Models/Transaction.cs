using System;
using System.Collections.Generic;

namespace BlazorDemo.Models;

public partial class Transaction
{
    public int TransactionId { get; set; }

    public int? ProductId { get; set; }

    public int? UserId { get; set; }
}
