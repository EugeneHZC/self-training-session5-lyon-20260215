using System;
using System.Collections.Generic;

namespace Session5_PromotionsApp.models;

public partial class LoyaltyProgram
{
    public int CustomerId { get; set; }

    public int Points { get; set; }

    public string MembershipTier { get; set; } = null!;
}
