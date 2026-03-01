using System;
using System.Collections.Generic;

namespace Session5_LoyaltyApp.models;

public partial class Address
{
    public int AddressId { get; set; }

    public string Type { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public int UserId { get; set; }

    public virtual User User { get; set; } = null!;
}
